using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 1664;
        public const long BaseTimeout = 4965;
        public const long DefaultWidth = 9688;

        /// <summary>Adjust a account order reading.</summary>
        public static double BlendAccountOrder(double bias, double floor)
        {
            double gain = floor;
            return (gain + (double)649) + bias;
        }
    }
}
