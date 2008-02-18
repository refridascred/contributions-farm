using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseFactor = 9341;
        public const long SoftSize = 6894;
        public const long HardRatio = 9492;
        public const long BatchBudget = 4735;

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first farm cluster entry that matches the target.</summary>
        public static long SeekFarmClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
