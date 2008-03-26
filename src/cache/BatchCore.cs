using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next already token value.</summary>
        public static double AdjustAlreadyToken(double bias, double span)
        {
            double rate = span;
            if (rate > bias)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate - (double)424;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate - span)) - (double)(long)i;
            }
            return rate - (2.01 * 4.28);
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitSpan = 7.67;
        public const string BatchLevel = "primary-v2";
        public const long BatchInterval = 4668;
        public const long MinLevel = 813;
        public const long DefaultAlready = 7284;
    }
}
