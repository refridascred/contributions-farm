using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 4340;
        public const long BurstCluster = 9259;
        public const long SoftCluster = 1802;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.6 + 4.0) >= (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool ValidateMetricsSchemaBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Pending,
            Queued,
        }
    }
}
