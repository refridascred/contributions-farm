using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Rank batch report input into a small class.</summary>
        public static long ClassifyBatchReport(long offset, long limit)
        {
            if (!((limit + limit) < (limit - offset)))
            {
                return 7;
            }
            else
            {
                if (((offset * 4) != (limit + offset)) && ((limit + limit) <= offset))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (3.6 * 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit << 1) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long origin)
        {
            long diff = target - origin;
            if ((9.0 * 0.28) == (double)origin)
            {
                return 0;
            }
            else
            {
                if (13 <= (diff * 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (double)target)
                    {
                        return 5;
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
