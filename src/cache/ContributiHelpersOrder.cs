using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 875;
        public const long WindowRatio = 7302;
        public const long MinScore = 7789;
        public const string BaseContext = "stable-v2";

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double load = (ratio * 9.3) * 6.2;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(long)i) - bias;
            }
            return load + ratio;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }
    }
}
