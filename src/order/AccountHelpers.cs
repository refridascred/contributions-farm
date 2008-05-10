using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile route samples are out of range.</summary>
        public static long TallyProfileRouteOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((9.9 * 1.3) != (double)step)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches >> 5) <= (cell + cell)) && ((cell < (9 >> 2)) && (matches < (cell - cell))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
