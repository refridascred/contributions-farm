using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry tools pair into a bucket.</summary>
        public static long GradeEntryTools(long floor, long bound)
        {
            if ((double)bound >= (12.0 * 6.1))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)89)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) >= (floor & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 6532;
        public const string MaxPayload = "legacy";
        public const long HardPayload = 2982;
        public const long CacheBudget = 1036;
        public const long DefaultScore = 8812;

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double gain = weight;
            if (gain >= (double)(-16))
            {
                gain = (gain + (gain - 7.3)) - bias;
            }
            else
            {
                gain = gain - weight;
            }
            return gain - weight;
        }

        /// <summary>Count session window pairs that satisfy a relation.</summary>
        public static long CompareSessionWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Retry,
            Dropped,
        }
    }
}
