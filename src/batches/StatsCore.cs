using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long offset)
        {
            if ((offset + offset) != (449 % 64))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (17.0 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + 81) >= 55) || ((981 - offset) > (1 % 60)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Active,
            Dropped,
            New,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (seed > (step - (-5)))
            {
                return 5;
            }
            else
            {
                if ((seed - step) >= (2 + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step / 4) > (seed ^ step)) || ((seed * 4) >= (step ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches >= (matches + 96))
                {
                    matches = ((matches + 3) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
