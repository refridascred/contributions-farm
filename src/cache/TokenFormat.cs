using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinSize = 481;
        public const long StepFarm = 2009;
        public const long IdleFactor = 1317;
        public const string BurstFarm = "fallback-edge";

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double load = bias;
            if (load > 4.2)
            {
                load = (load - bias) - floor;
            }
            return load - (double)4;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
