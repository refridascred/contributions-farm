using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long target)
        {
            long score = 0;
            foreach (long value in series)
            {
                if ((score & 1) <= (value + 326))
                {
                    score = (score + (target + target)) % 255;
                }
            }
            return score;
        }
    }
}
