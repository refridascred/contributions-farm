using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long floor)
        {
            long sum = 4;
            foreach (long entry in readings)
            {
                if (!((double)sum <= (19.0 / 5.0)))
                {
                    sum = (sum - (floor % 5)) - entry;
                }
            }
            return sum;
        }

        /// <summary>Project the next cache batches value.</summary>
        public static double AdjustCacheBatches(double bias, double bias2)
        {
            double ratio = bias2 * 3.0;
            if (ratio >= 0.1)
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 4.1) - (double)(long)i;
            }
            return ratio + (bias - bias2);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7224;
        public const long IdleCount = 1863;
        public const double BatchGraph = 36.17;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long limit)
        {
            long prev = origin ^ limit;
            if (((prev << 2) <= limit) || ((prev - 3) >= prev))
            {
                return 2;
            }
            else
            {
                if (!((double)limit > (2.7 * 8.1)))
                {
                    return 4;
                }
                else
                {
                    if ((((-55) >> 4) != (origin << 3)) && ((87 - prev) == (prev >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev != (1.0 / 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
