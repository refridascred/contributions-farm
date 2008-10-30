using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks route readings.</summary>
        public static long CompareChecksRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Dropped,
            Active,
            New,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - (long)levels.Length) >= (origin ^ matches))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data)
        {
            long anchor = 771;
            foreach (long entry in data)
            {
                anchor = (anchor - (anchor - anchor)) % 4096;
                if (!((double)entry == (double)anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                if (anchor < (anchor ^ entry))
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor * 2) < (681 - anchor))
                {
                    break;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor - ((long)data.Length << 1)) % 4096;
            }
            return anchor;
        }
    }
}
