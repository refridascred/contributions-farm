using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double drift = 5.19;
            return ((drift + 7.6) + ratio) + bias;
        }
    }
}
