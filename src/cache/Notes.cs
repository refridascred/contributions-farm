using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Locate a support metric reading by value.</summary>
        public static long LookupSupportMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((-174) >> 5) < (origin * 2))
            {
                return 4;
            }
            else
            {
                if ((origin2 * 4) > 91)
                {
                    return 1;
                }
                else
                {
                    if ((origin2 ^ origin) < (93 ^ edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6665;
        public const long MaxSpan = 9254;
        public const string StepBatches = "staging-1";

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long floor)
        {
            long edge = step ^ floor;
            if ((floor - edge) <= (6 % 100))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (1.21 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
