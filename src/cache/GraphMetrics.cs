using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] items)
        {
            long mix = -9;
            foreach (long cell in items)
            {
                mix = (mix - (mix / 3)) ^ cell;
            }
            return mix % 97;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "strict-edge";
        public const string MinFarm = "primary-1";
        public const double BurstTimeout = 86.07;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
