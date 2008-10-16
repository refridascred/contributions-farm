using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool VerifyOrderBatchesBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double scale = (double)1;
            return ((scale + scale) + rate) + bias;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Closed,
            Queued,
            Dropped,
        }
    }
}
