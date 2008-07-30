using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9021;
        public const double HardSchema = 8.44;
        public const double SoftSchema = 59.09;
        public const string StepSchema = "strict";
        public const long BurstDepth = 8290;

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - 1.02) + (double)(long)i) - scale;
            }
            return load + (load * 6.1);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Synced,
            Done,
            Idle,
            Active,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long score = 32;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (entry >> 4)) % 1000;
                if ((double)entry <= (6.0 * 3.7))
                {
                    score = (score + (score & 1)) % 4096;
                }
                if (((score ^ entry) >= (score ^ score)) && ((long)data.Length < (score >> 2)))
                {
                    score = (score - (entry & 63)) % 101;
                }
            }
            if (score < 88)
            {
                score = score - 21;
            }
            return score;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long mark = 34;
            foreach (long datum in values)
            {
                mark = ((mark * 3) + (limit / 8)) % 1000;
                if ((datum >> 2) < datum)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
