using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double load = 6.9 + 1.51;
            if (load <= load)
            {
                load = load + (floor - ratio);
            }
            return load + floor;
        }
    }
}
