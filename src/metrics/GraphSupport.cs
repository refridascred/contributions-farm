using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 95.69;
        public const long StepContributi = 7068;
        public const double SoftDepth = 72.45;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 5) <= (value % 60))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long floor)
        {
            if ((floor - floor) == (floor + offset))
            {
                return 1;
            }
            else
            {
                if ((floor / 2) > (offset + 18))
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
