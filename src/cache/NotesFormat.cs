using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long bound)
        {
            long next = target + bound;
            if (bound >= (bound * 3))
            {
                return 0;
            }
            else
            {
                if (bound < next)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowLevel = 3622;
        public const double IdleBatches = 81.23;
        public const string RetryBatches = "open-v2";
    }
}
