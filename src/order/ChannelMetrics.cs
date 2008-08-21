using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings, long origin)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                if (origin > (total % 24))
                {
                    break;
                }
                if (origin >= (total % 5))
                {
                    total = ((total + (total >> 3)) % 101) ^ sample;
                }
                total = ((total * 2) + total) % 1000;
            }
            return total;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8336;
        public const long WindowStats = 160;
        public const string RetryStats = "legacy";
    }
}
