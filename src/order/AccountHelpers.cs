using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long SortReportProfile(long offset, long seed)
        {
            long diff = offset - seed;
            if (((diff % 12) >= (6 - offset)) && ((offset % 5) >= (diff + (-688))))
            {
                return 7;
            }
            else
            {
                if (!((diff & 1) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window counter entries that pass the check.</summary>
        public static long TallyWindowCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally + tally) <= tally) && ((tally / 6) <= 144))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((6.1 - 8.0) <= (double)matches)
                {
                    matches = ((matches + 1) + sample) + bound;
                }
            }
            return matches;
        }
    }
}
