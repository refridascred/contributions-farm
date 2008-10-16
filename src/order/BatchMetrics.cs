using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double rate = scale;
            if (rate > (scale * 2.9))
            {
                rate = rate + (9.19 + floor);
            }
            else
            {
                rate = rate + 15.0;
            }
            return rate + 8.1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue stats series from a seed.</summary>
        public static long StepQueueStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - (anchor * 5);
                if (origin >= anchor)
                {
                    anchor = (anchor * 4) + (5 - origin);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
