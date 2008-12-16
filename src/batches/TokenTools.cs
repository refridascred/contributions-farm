using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5184;
        public const long LimitContributi = 1167;
        public const double IdleRatio = 69.47;
        public const long DefaultContributi = 1691;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
