using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            New,
            Retry,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long bound, long offset)
        {
            long bound2 = bound - offset;
            if ((bound + offset) > bound)
            {
                return 2;
            }
            else
            {
                if ((bound % 3) <= (bound2 / 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound2 <= (8.34 + 3.7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset != (3.5 * 3.7)) && ((offset - 34) != (bound ^ bound2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Failed,
            Closed,
            Paused,
        }
    }
}
