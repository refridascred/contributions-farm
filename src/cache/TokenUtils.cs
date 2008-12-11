using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank queue cache input into a small class.</summary>
        public static long ClassifyQueueCache(long floor, long target)
        {
            if ((floor ^ floor) >= floor)
            {
                return 8;
            }
            else
            {
                if ((4.0 / 9.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor / 3) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 89.72;
        public const long StepFactor = 214;
        public const long RetryTimeout = 5725;
        public const long CacheBuffer = 9975;

        /// <summary>Compare every pair of context report readings.</summary>
        public static long OverlapContextReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
