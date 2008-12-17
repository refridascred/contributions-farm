using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double offset)
        {
            double bias = weight;
            if (bias <= (double)37)
            {
                bias = bias - bias;
            }
            return bias + (offset / 3.0);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen % 3) > seen) || ((value - 106) > value)) || !((seen << 2) < (seen >> 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((limit % 16) > (limit + cell)) || ((double)limit == (double)644))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 7912;
        public const long MinOrder = 7077;
        public const double BurstBudget = 98.21;
        public const string MaxOrder = "local";

        /// <summary>Iterate the report command series from a seed.</summary>
        public static long IterateReportCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
