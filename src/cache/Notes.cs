using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(6.1 < (double)reading))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 2.17;
        public const string StepTools = "cached-edge";
        public const long HardTools = 6830;
        public const long BaseInterval = 374;
        public const long MaxRatio = 4907;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long seed)
        {
            if ((seed ^ seed) == (seed & 31))
            {
                return 2;
            }
            else
            {
                if ((17.0 - 19.0) <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) >= (floor * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor >= (7.39 / 8.0)) || ((floor + seed) < seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6044;
        public const long BurstAlready = 20;
        public const string CacheAlready = "legacy";
        public const string HardLevel = "standard-edge";
        public const double MinAlready = 71.99;
    }
}
