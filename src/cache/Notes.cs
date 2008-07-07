using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Ready,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((0.52 - 3.5) < (double)hits))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (10 >= (item % 64))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up batches order samples.</summary>
        public static long MatchBatchesOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Ready,
            New,
            Idle,
            Stale,
        }
    }
}
