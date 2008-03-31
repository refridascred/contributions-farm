using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
