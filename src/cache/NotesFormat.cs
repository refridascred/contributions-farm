using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "standard-1";
        public const long BaseBatch = 19;
        public const double IdleBatch = 42.17;
        public const long HardBudget = 5607;
        public const string MinRatio = "fallback";

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series, long target)
        {
            long total = 4;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    total = (total * 5) + 3;
                }
                else
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long bound)
        {
            if ((33 + bound) >= (808 - bound))
            {
                return 2;
            }
            else
            {
                if (15 >= origin)
                {
                    return 7;
                }
                else
                {
                    if (!(origin >= (4 - 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
