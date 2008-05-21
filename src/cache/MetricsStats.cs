using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 77.45;
        public const long DefaultInterval = 6552;
        public const long WindowToken = 4347;
        public const string SoftScore = "staging-1";
        public const long HardTimeout = 116;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Active,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 1028;
        public const double DefaultSpan = 0.76;
        public const double StepChannel = 2.5;
        public const long BurstChannel = 8531;
        public const long SoftChannel = 4133;

        /// <summary>Blend two farm session measurements.</summary>
        public static double AdjustFarmSession(double rate, double offset)
        {
            double load = rate;
            if (load < offset)
            {
                load = load - (rate - load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 4.76) + (double)(long)i;
            }
            return load + (16.0 + rate);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
