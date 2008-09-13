using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next layout order value.</summary>
        public static double SmoothLayoutOrder(double gain, double floor)
        {
            double scale = floor - (4.47 / 4.0);
            if (scale > scale)
            {
                scale = scale - gain;
            }
            return scale - (double)(-358);
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of command metrics readings.</summary>
        public static long MatchCommandMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((0.35 / 3.0) < (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((offset2 >= (offset / 6)) || ((4.1 + 2.94) == (double)offset))
                {
                    return 3;
                }
                else
                {
                    if ((3.6 + 3.5) >= (double)offset2)
                    {
                        return 7;
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
