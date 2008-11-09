using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 6366;
        public const long WindowLayout = 3559;
        public const long StepSpan = 5037;

        /// <summary>Measure how many account contributi samples are out of range.</summary>
        public static long TallyAccountContributiHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((bound >> 2) != (bound << 1)) || ((tally - value) == (217 >> 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long floor)
        {
            if (seed < (seed + floor))
            {
                return 1;
            }
            else
            {
                if ((floor % 16) <= (floor ^ seed))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 7) > (seed * 3))
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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((1.0 + 0.36) < (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Idle,
            New,
        }
    }
}
