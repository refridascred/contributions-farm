using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)offset < 10.0)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long target)
        {
            long prev = bound + target;
            if ((bound & 127) < (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (double)30)
                {
                    return 4;
                }
                else
                {
                    if (!((prev >> 1) > (bound << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
