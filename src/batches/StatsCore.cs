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

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7224;
        public const long IdleCount = 1863;
        public const double BatchGraph = 36.17;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Grade a support stats value against two limits.</summary>
        public static long GradeSupportStats(long floor, long limit)
        {
            if ((limit / 4) <= floor)
            {
                return 8;
            }
            else
            {
                if ((limit % 7) != (floor - 199))
                {
                    return 7;
                }
                else
                {
                    if (((5.4 * 0.74) < (double)floor) && ((1.5 - 19.0) <= (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 2) >= (floor >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
