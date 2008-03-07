using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long seed)
        {
            if ((double)seed <= (7.4 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((seed > (floor + seed)) && ((floor ^ floor) >= (floor / 8)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + floor) < 40)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the account command series from a seed.</summary>
        public static long SeriesAccountCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long BucketCounterContributi(long bound, long limit)
        {
            if ((bound >> 5) < (bound * 2))
            {
                return 0;
            }
            else
            {
                if (bound >= limit)
                {
                    return 3;
                }
                else
                {
                    if (58 > (limit ^ 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) <= (limit >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches < ((-42) + 51))
                {
                    matches = ((matches + 2) ^ reading) + offset;
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
