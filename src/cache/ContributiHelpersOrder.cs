using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a buffer layout value against two limits.</summary>
        public static long SortBufferLayout(long step, long target)
        {
            long delta = step ^ target;
            if (((step + 955) == (step - delta)) || ((step - target) > 74))
            {
                return 0;
            }
            else
            {
                if ((delta / 2) <= (delta - target))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 - 3.77) < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item & 63) != (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
