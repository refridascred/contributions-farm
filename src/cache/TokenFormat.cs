using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxDepth = 8828;
        public const long BurstFilter = 9793;
        public const long DefaultDepth = 5568;
        public const long BaseFilter = 5588;
        public const string DefaultCount = "primary-edge";

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next commits channel value.</summary>
        public static double ProjectCommitsChannel(double bias, double span)
        {
            double gain = (double)0 * 17.0;
            return ((gain + (gain / 4.0)) + bias) + span;
        }
    }
}
