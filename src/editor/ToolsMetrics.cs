using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((1 << 1) < cell) && (cell > (1 + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next format filter value.</summary>
        public static double SmoothFormatFilter(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (8.0 * 4.0)) - (double)(long)i) - bias;
            }
            return ratio - scale;
        }
    }
}
