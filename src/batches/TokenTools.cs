using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxRatio = 1634;
        public const double CacheNotes = 98.96;
        public const double DefaultInterval = 20.01;
        public const long DefaultFactor = 5407;
    }
}
