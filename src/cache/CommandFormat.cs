using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a cache context reading by value.</summary>
        public static long LookupCacheContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item >= (17.0 - 1.0))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long BucketReportFilter(long origin, long offset)
        {
            if ((982 & 31) >= (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 31) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((25 * 3) > diff)
            {
                return 4;
            }
            else
            {
                if ((diff + diff) > (diff - seed))
                {
                    return 8;
                }
                else
                {
                    if ((bound - 2) <= (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
