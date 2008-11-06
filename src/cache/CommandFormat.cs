using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            New,
            Paused,
            Active,
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double bias, double offset)
        {
            double bias2 = bias;
            return (bias2 - (bias2 + bias)) + offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 24.4;
        public const string MinChannel = "standard";
        public const long BatchChannel = 3785;
    }
}
