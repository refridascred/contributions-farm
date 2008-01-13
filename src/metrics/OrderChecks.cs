using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            New,
            Active,
            Retry,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seed + seed) >= (seen % 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
