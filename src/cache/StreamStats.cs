using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter checks values into a single score.</summary>
        public static long FoldFilterChecks(long[] series, long seed)
        {
            long sum = 1;
            foreach (long sample in series)
            {
                if (!((seed - seed) >= sum))
                {
                    sum = (sum ^ (sum + 2)) ^ sample;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            if (sum > 46)
            {
                sum = ((sum * 2) + (6 / 9)) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 210;
            foreach (long item in samples)
            {
                if (result >= item)
                {
                    result = result + (item >> 5);
                }
            }
            if (result > 428)
            {
                result = (result << 3) ^ 34;
            }
            return result % 4096;
        }
    }
}
