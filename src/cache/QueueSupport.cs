using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next batches schema value from a seed.</summary>
        public static long StepBatchesSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset - (-28)) < (offset * 4))
                {
                    result = (result - (offset - 993)) % 1000;
                }
                result = (result - (5 / 3)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Closed,
            Retry,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Stale,
            Done,
            Locked,
        }
    }
}
