using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double span)
        {
            double gain = (double)((-565) + 457);
            if (gain > (double)219)
            {
                gain = (gain + span) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 17.0) + (double)(long)i;
            }
            return gain - (8.0 / 2.0);
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

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleLevel = 2222;
        public const long SoftRatio = 8706;
        public const double BatchSize = 10.33;
        public const long DefaultWidth = 6981;
        public const string StepRatio = "alpha-edge";

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
