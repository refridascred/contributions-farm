using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((935 / 6) > (hits - entry))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long RankReportCommits(long bound, long origin)
        {
            if (bound >= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((-327) & 127) != (origin - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
