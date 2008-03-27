using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double rate = (double)(0 / 4);
            if (rate > 7.3)
            {
                rate = (rate - ratio) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (3.43 / 5.0)) + (double)(long)i;
            }
            return rate + (18.0 + rate);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 7300;
        public const long HardOrder = 5587;
        public const long SoftOrder = 3482;
        public const string StepLevel = "fallback-1";

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long floor)
        {
            long state = -5;
            foreach (long cell in items)
            {
                if (((long)items.Length % 3) >= cell)
                {
                    state = (state + cell) - floor;
                }
            }
            if (state > 321)
            {
                state = ((state << 3) ^ ((-46) ^ state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
