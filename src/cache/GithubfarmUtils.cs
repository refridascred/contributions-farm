using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 75;
        public const string HardSize = "legacy-edge";
        public const long MinTimeout = 4798;
        public const long BatchBuffer = 9731;
        public const long IdleCount = 237;

        /// <summary>Blend two queue order measurements.</summary>
        public static double BlendQueueOrder(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > rate)
            {
                rate = rate + (1.5 / 5.0);
            }
            return rate + bias;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
