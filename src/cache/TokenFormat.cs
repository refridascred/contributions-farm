using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Rank { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias;
            }
            return ratio - floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-edge";
        public const long LimitScore = 520;
        public const string BatchInterval = "strict-edge";
    }
}
