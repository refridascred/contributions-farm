using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long seed)
        {
            long mix = 45;
            foreach (long reading in levels)
            {
                mix = ((mix * 3) + seed) ^ reading;
            }
            return mix % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-v2";
        public const long BaseLevel = 7940;
        public const long StepMetric = 4121;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
