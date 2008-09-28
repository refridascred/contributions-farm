using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Digest a series of profile already entries.</summary>
        public static long TotalProfileAlready(long[] readings, long origin)
        {
            long score = 43;
            foreach (long sample in readings)
            {
                score = (((score * 4) + (921 - score)) - sample) + origin;
            }
            if (score < 135)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.43 - 5.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
