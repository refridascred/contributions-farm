using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long CountBufferCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((95 & 63) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample == (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool GuardPayloadQueueRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
