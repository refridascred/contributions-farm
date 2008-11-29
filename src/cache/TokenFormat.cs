using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length << 3) < (target + (-3)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entry entries that pass the check.</summary>
        public static long MeasureToolsEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(16.0 < (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank batch layout input into a small class.</summary>
        public static long GradeBatchLayout(long offset, long floor)
        {
            long span = offset + floor;
            if ((span / 8) >= (offset & 1))
            {
                return 5;
            }
            else
            {
                if ((double)span < (7.9 - 7.6))
                {
                    return 6;
                }
                else
                {
                    if ((double)span == (8.23 - 13.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset == (10.0 / 7.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
