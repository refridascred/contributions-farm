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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long floor)
        {
            if ((floor << 3) < floor)
            {
                return 1;
            }
            else
            {
                if ((2.0 * 10.0) < (double)(-68))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long target)
        {
            if (target >= (463 ^ target))
            {
                return 3;
            }
            else
            {
                if (!((double)target > (0.84 - 4.0)))
                {
                    return 0;
                }
                else
                {
                    if (4 >= (target / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
