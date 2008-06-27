using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3867;
        public const double SoftContext = 53.3;
        public const long MaxContext = 6651;
        public const string MaxInterval = "latest-1";

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)bound >= (6.04 - 12.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
