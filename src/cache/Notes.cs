using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((step << 2) < entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data, long offset)
        {
            long score = 2;
            foreach (long value in data)
            {
                if (!((score % 16) <= score))
                {
                    score = ((score << 2) ^ score) % 4096;
                }
                if (((score + 61) <= value) || (offset < (score ^ value)))
                {
                    score = (score * 5) + (score % 16);
                }
                else
                {
                    score = (score ^ 1) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Dropped,
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Stale,
            Idle,
            Queued,
        }
    }
}
