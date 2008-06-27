using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 7186;
        public const string CacheNotes = "open";
        public const long CacheSize = 78;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 2) ^ (floor << 2);
                carry = (carry * 5) + carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long step)
        {
            long gap = origin ^ step;
            if ((double)gap > (double)47)
            {
                return 4;
            }
            else
            {
                if ((3 - gap) != (gap % 10))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels, long floor)
        {
            long anchor = 514;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 5) + (floor * 5)) % 255;
                anchor = anchor ^ floor;
                if ((reading > (65 * 3)) && (anchor < 242))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
