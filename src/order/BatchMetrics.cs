using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Ready,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double bias2 = (double)(719 * 3);
            if (bias2 < (double)0)
            {
                bias2 = bias2 - (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 + 14.0;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ item) >= (item + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long target)
        {
            long cur = limit ^ target;
            if (!((7.0 - 3.5) > (double)target))
            {
                return 1;
            }
            else
            {
                if (target >= 40)
                {
                    return 8;
                }
                else
                {
                    if (((target << 3) == (cur + limit)) && ((cur + target) < (limit - target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target * 2) < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long target)
        {
            if ((double)floor == (6.3 - 7.79))
            {
                return 7;
            }
            else
            {
                if ((floor / 4) >= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
