using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank account cache input into a small class.</summary>
        public static long SortAccountCache(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if ((double)447 >= (double)offset2)
            {
                return 6;
            }
            else
            {
                if (!((double)edge == (double)offset2))
                {
                    return 4;
                }
                else
                {
                    if (offset2 <= (942 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((874 - offset2) > edge) || ((offset % 100) == (offset >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (9.84 / 4.0)) && ((double)seen < (5.8 * 2.86)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] series)
        {
            long result = 80;
            foreach (long datum in series)
            {
                if ((result + 2) != (result + datum))
                {
                    result = result - (result - datum);
                }
                result = ((result * 5) + (long)series.Length) % 101;
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > 5)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue command reading by value.</summary>
        public static long LocateQueueCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
