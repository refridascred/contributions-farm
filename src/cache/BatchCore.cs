using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            New,
            Paused,
            Ready,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long offset)
        {
            if (((offset / 9) < offset) && ((step ^ (-72)) > offset))
            {
                return 8;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            New,
            Draft,
            Ready,
            Dropped,
        }
    }
}
