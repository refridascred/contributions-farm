using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local";
        public const long SoftDepth = 6376;
        public const long BurstGraph = 3522;
        public const long LimitWidth = 8208;
        public const long DefaultSize = 2498;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5841;
        public const long HardLayout = 7657;
        public const double MinLayout = 98.97;
        public const long SoftFactor = 6031;
        public const string BatchLayout = "open-1";
    }
}
