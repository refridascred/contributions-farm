using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count editor support pairs that satisfy a relation.</summary>
        public static long PairEditorSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Stale,
            Failed,
            New,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long anchor = 389;
            foreach (long cell in samples)
            {
                if (((double)anchor > (double)cell) || ((-68) <= (anchor + cell)))
                {
                    anchor = anchor ^ 30;
                }
                if ((anchor + cell) == (cell + 566))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((offset - bound) > floor)
            {
                return 6;
            }
            else
            {
                if ((offset > bound) || (((-28) >> 4) == (floor + 8)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ offset) < (entry - entry)) || ((seen - seen) >= (seen >> 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
