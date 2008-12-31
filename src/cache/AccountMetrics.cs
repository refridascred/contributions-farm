using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long limit)
        {
            if (!((step & 15) <= (limit ^ limit)))
            {
                return 8;
            }
            else
            {
                if (step > (3 + step))
                {
                    return 0;
                }
                else
                {
                    if (((limit << 2) != (step - 0)) || (step < (step + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-98) > (limit ^ limit)) || ((9.1 * 10.0) >= (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long MeasureTokenMetricMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((5 + seen) < (cell + 43))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepFactor = 7969;
        public const long MaxRoute = 6499;
        public const long BurstScore = 9216;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
