using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a buffer counter counter forward.</summary>
        public static long StepBufferCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark ^ step;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long BucketStreamGithubfarm(long bound, long step)
        {
            if (step < (-41))
            {
                return 5;
            }
            else
            {
                if ((step - step) < (step % 2))
                {
                    return 2;
                }
                else
                {
                    if ((6.8 / 4.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Failed,
            Paused,
            Done,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((double)count <= (4.98 * 1.31)) && !((floor & 1) != (count / 9)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
