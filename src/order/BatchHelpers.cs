using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items, long origin)
        {
            long state = 9;
            foreach (long cell in items)
            {
                state = (state + (cell % 60)) % 65521;
                state = ((state * 5) + (origin ^ 129)) % 4096;
            }
            if (state < 3)
            {
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
