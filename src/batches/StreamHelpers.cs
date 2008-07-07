using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long ScoreStreamCounter(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = ((total * 5) + datum) % 255;
            }
            return total % 97;
        }

        /// <summary>Locate a tools record reading by value.</summary>
        public static long LookupToolsRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long CountAlreadyEntryHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)count == (double)82)
                {
                    count = ((count + 3) ^ cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long RankFarmChannel(long origin, long bound)
        {
            if (!((origin + origin) > 532))
            {
                return 4;
            }
            else
            {
                if (((-26) >= origin) && ((792 - origin) <= bound))
                {
                    return 8;
                }
                else
                {
                    if (origin <= 226)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
