using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
