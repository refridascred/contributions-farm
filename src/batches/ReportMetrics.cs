using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (1.0 < (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 << 2) != (origin + (-23)))
                {
                    return 0;
                }
                else
                {
                    if ((origin2 - origin2) != (origin & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of stats route readings.</summary>
        public static long DigestStatsRoute(long[] levels)
        {
            long score = 352;
            foreach (long cell in levels)
            {
                score = ((score * 3) + (score / 9)) % 255;
                if ((3 >> 5) <= (score ^ cell))
                {
                    score = (score ^ (cell - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Pending,
            Stale,
            Closed,
            Failed,
        }
    }
}
