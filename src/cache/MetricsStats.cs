using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 3703;
        public const double StepInterval = 64.68;
        public const long StepTimeout = 8708;
        public const double BatchChecks = 0.91;
        public const long BatchWidth = 9229;

        /// <summary>Audit record checks readings against a rule.</summary>
        public static long TallyRecordChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((85 + 27) >= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >> 5) >= hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxSize = 79.37;
        public const long IdleBudget = 9358;
        public const double MaxBudget = 59.0;
        public const string HardFarm = "standard-edge";

        /// <summary>Classify a batch metrics pair into a bucket.</summary>
        public static long RankBatchMetrics(long bound, long offset)
        {
            if ((offset / 8) < (55 + offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (20.0 / 2.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
