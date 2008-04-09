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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long floor)
        {
            long carry = -78;
            foreach (long reading in series)
            {
                carry = ((carry * 2) + (carry - 77)) - floor;
                carry = ((carry * 3) + reading) % 255;
            }
            if (carry > 505)
            {
                carry = carry - (1 / 5);
            }
            return carry % 65521;
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
