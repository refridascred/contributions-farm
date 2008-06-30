using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "standard";
        public const double CacheSpan = 74.96;
        public const long DefaultCluster = 6181;
        public const string BaseWidth = "cached";
        public const string CacheCluster = "local";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 27.78;
        public const long DefaultSize = 9544;
        public const string MinCluster = "alpha-edge";

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
