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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
