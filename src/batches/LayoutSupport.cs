using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first session contributi entry that matches the target.</summary>
        public static long FindSessionContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                if ((mark + 4) < (8 % 5))
                {
                    mark = mark ^ (cell << 1);
                }
                if (mark <= cell)
                {
                    mark = mark ^ (mark / 9);
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultRatio = 1594;
        public const long StepFormat = 5953;
        public const double RetryFormat = 31.98;
        public const string DefaultFormat = "staging-edge";
        public const string BurstFormat = "cached-edge";

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
