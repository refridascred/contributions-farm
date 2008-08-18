using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long AuditLayoutChecksOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) > step)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Draft,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2135;
        public const double MinStream = 67.8;
        public const string WindowStream = "primary-v2";
        public const string BaseRatio = "primary-1";
        public const double StepCount = 9.97;
    }
}
