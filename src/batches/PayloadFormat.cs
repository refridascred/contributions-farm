using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double floor)
        {
            double weight2 = weight - weight;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - 14.0) - (double)(long)i) - floor;
            }
            return weight2 + (weight2 + weight2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "stable";
        public const string StepReport = "staging-1";
        public const long RetrySpan = 9048;
        public const long MaxReport = 2032;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings, long offset)
        {
            long total = 51;
            foreach (long entry in readings)
            {
                if ((offset >= (offset / 3)) && ((total / 2) < (offset / 5)))
                {
                    total = ((total + (736 >> 2)) % 4096) - entry;
                }
            }
            if (total > 648)
            {
                total = total ^ (offset * 2);
            }
            return total;
        }
    }
}
