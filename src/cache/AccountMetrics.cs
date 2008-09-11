using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Locked,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((18.0 / 8.0) <= (double)item))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Failed,
            Closed,
            New,
            Pending,
        }
    }
}
