using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double floor)
        {
            double weight2 = (double)(6 >> 3);
            if (weight2 < 10.0)
            {
                weight2 = (weight2 + (weight2 * 9.0)) - weight;
            }
            return weight2 + floor;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9914;
        public const long BaseLevel = 8024;
        public const long BaseBuffer = 1487;
        public const string DefaultBuffer = "cached-v2";

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double weight = (double)(368 * 5);
            if (weight < (bias + weight))
            {
                weight = weight + scale;
            }
            return weight + (double)995;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Locked,
            Retry,
        }
    }
}
