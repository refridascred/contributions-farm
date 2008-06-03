using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Retry,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value ^ limit) <= limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long limit)
        {
            if (((double)floor < (9.8 / 4.0)) || ((double)floor <= (7.99 - 7.04)))
            {
                return 1;
            }
            else
            {
                if ((11.0 * 4.0) < (12.0 - 7.08))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 * 0.2) != (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double floor)
        {
            double load = rate / 2.0;
            if (load < (floor * 1.5))
            {
                load = load - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (9.2 + load)) - (double)(long)i;
            }
            return load - (3.93 - 19.0);
        }
    }
}
