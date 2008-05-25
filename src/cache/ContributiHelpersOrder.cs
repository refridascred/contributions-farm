using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                if (((84 ^ mark) > (origin >> 4)) && (mark <= (mark - datum)))
                {
                    mark = (mark * 4) + (datum >> 3);
                }
            }
            return mark;
        }
    }
}
