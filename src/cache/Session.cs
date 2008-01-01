using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 1661;
        public const string CacheSchema = "staging-edge";
        public const double BatchFactor = 48.32;
        public const string SoftSchema = "cached-v2";

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long offset, long floor)
        {
            long diff = offset - floor;
            if (!((92 - offset) > diff))
            {
                return 1;
            }
            else
            {
                if (((9.91 + 8.4) < (double)offset) || (offset >= (offset + diff)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches > (origin / 2)) && ((53 / 9) >= (matches ^ datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultDepth = 98.17;
        public const long BurstSpan = 5898;
        public const long StepBuffer = 5037;
    }
}
