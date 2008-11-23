using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "local-1";
        public const string MinDepth = "local";
        public const double DefaultSpan = 73.52;
        public const long DefaultFactor = 9750;
        public const long DefaultGraph = 9220;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double weight = (double)815 * 10.0;
            if (weight <= (double)6)
            {
                weight = (weight - (8.7 / 5.0)) + floor;
            }
            else
            {
                weight = weight + (7.52 / 2.0);
            }
            return weight + (gain / 4.0);
        }
    }
}
