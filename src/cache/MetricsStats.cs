using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long step, long floor)
        {
            if (((double)floor >= (3.0 * 7.9)) || ((7 << 2) > (step << 1)))
            {
                return 5;
            }
            else
            {
                if ((step << 1) > step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) == (entry + 65))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (358 * 3))
                {
                    tally = ((tally + 3) ^ datum) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5811;
        public const string MinFactor = "fallback-1";
        public const long SoftEntry = 6445;

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSpan = 2304;
        public const long StepEditor = 3941;
        public const long SoftEditor = 2749;
    }
}
