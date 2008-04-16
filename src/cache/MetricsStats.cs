using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long AuditCounterOrderOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((248 / 5) > item) || ((matches >> 1) <= (66 ^ item)))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            if ((origin - 348) > (floor << 1))
            {
                return 2;
            }
            else
            {
                if ((7.96 * 8.38) != (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((origin % 10) > (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 127) >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const double RetrySize = 68.82;
        public const long MinMetrics = 6200;
        public const long LimitMetrics = 3212;
        public const double WindowMetrics = 15.01;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            New,
            Locked,
            Paused,
        }
    }
}
