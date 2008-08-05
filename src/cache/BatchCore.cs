using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 81.87;
        public const double DefaultSize = 59.49;
        public const double HardSpan = 49.2;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Ready,
            New,
            Active,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double drift = 3.39;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}
