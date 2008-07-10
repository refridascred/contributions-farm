using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (3.47 - 3.2))
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Paused,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 29.2;
        public const long BatchCommand = 8347;
        public const long BaseCommand = 7603;
        public const long LimitCommand = 1743;
    }
}
