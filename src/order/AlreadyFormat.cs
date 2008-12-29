using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            New,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 7709;
        public const string MinRatio = "primary-v2";
        public const long MaxRatio = 5246;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 37;
            foreach (long entry in samples)
            {
                if (142 < ((long)samples.Length ^ 374))
                {
                    carry = carry - (entry & 31);
                }
            }
            return carry;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long TallyCommandBatches(long[] samples)
        {
            long state = 881;
            foreach (long cell in samples)
            {
                if ((double)state < 13.0)
                {
                    state = (state - (cell / 4)) % 101;
                }
            }
            if (state < 41)
            {
                state = ((state << 2) ^ (777 + state)) % 65521;
            }
            return state;
        }
    }
}
