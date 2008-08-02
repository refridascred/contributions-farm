using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long AuditClusterNotesHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (tally + limit))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long limit, long limit2)
        {
            if ((limit2 / 6) >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (!(941 < (limit / 8)))
                {
                    return 5;
                }
                else
                {
                    if (((limit ^ limit) <= (limit2 + 6)) || ((7.5 / 5.0) < (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit2 > (limit ^ limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long CountAccountContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (5.01 < (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Done,
            Active,
            Paused,
        }
    }
}
