using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long offset)
        {
            if (floor > (offset ^ floor))
            {
                return 1;
            }
            else
            {
                if (0.9 >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long ClassifyStreamMetric(long limit, long origin)
        {
            if ((origin ^ 803) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((origin & 3) <= (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (limit > (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit == (3.0 + 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Pending,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
