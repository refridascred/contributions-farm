using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 46) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleScore = 4755;
        public const long IdleRatio = 5063;
        public const long BaseRoute = 6774;
        public const double LimitRoute = 82.64;
    }
}
