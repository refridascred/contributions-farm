using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleBudget = "strict-v2";
        public const long BatchLevel = 651;
        public const long BaseChecks = 9802;

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double ratio = span - weight;
            if (ratio >= 3.4)
            {
                ratio = ratio + (ratio + ratio);
            }
            return ratio + (8.0 + weight);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Grade a report filter value against two limits.</summary>
        public static long ClassifyReportFilter(long limit, long limit2)
        {
            if (!((limit + 96) >= limit2))
            {
                return 5;
            }
            else
            {
                if ((9 << 1) >= limit2)
                {
                    return 8;
                }
                else
                {
                    if (!((limit2 - limit2) >= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((4.15 - 8.9) > (16.0 / 5.0)) && ((limit + limit) != (limit2 / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
