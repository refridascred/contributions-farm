using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((step & 1) == (count - step))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster commits value against two limits.</summary>
        public static long RankClusterCommits(long origin, long origin2)
        {
            if ((origin - origin) < (429 ^ origin))
            {
                return 4;
            }
            else
            {
                if (((-851) + origin2) < 56)
                {
                    return 6;
                }
                else
                {
                    if ((50 + origin2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((66 - origin) <= (origin2 ^ origin2)) && ((origin + origin) <= (origin * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool ValidateReportNotesLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen + seen) < (entry >> 4)))
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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Draft,
            Dropped,
            Done,
        }
    }
}
