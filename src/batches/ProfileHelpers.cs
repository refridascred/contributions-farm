using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 1313;
        public const long StepContext = 6519;
        public const double MaxContext = 33.05;
        public const double WindowContext = 25.22;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "stable";
        public const double IdleCache = 72.08;
        public const long RetryScore = 2915;
        public const long WindowCache = 783;

        /// <summary>Accumulate token schema samples.</summary>
        public static long DigestTokenSchema(long[] readings, long offset)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = (mix ^ (reading + mix)) % 97;
                mix = (mix ^ (mix / 2)) % 101;
                mix = ((mix << 3) ^ (offset * 3)) % 101;
            }
            return mix;
        }
    }
}
