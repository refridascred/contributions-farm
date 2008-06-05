using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if (((floor + floor) == (832 * 3)) || (floor <= (floor << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 > (6.0 - 10.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank session stats input into a small class.</summary>
        public static long BucketSessionStats(long step, long seed)
        {
            if (((seed >> 5) != (seed * 5)) || (seed <= (seed + seed)))
            {
                return 2;
            }
            else
            {
                if ((double)93 == (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((step <= (seed ^ seed)) && ((double)seed > (8.8 - 2.4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin > (item * 2)) && ((origin + 8) <= (origin << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
