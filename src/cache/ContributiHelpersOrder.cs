using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached";
        public const long SoftOrder = 7104;
        public const long LimitDepth = 9771;
        public const double BaseFactor = 41.38;

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                long count = (20 ^ 3) + (seed & 1);
                mark = mark ^ count;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value << 1) >= (value + origin))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
