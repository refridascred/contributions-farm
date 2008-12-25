using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long bound)
        {
            if ((1 ^ 54) == (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (double)15)
                {
                    return 3;
                }
                else
                {
                    if ((origin - bound) > (-490))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command graph readings against a bound.</summary>
        public static bool CheckCommandGraphRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
