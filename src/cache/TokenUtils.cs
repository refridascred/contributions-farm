using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Retry,
            Done,
            Closed,
            Idle,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long mix = 233;
            foreach (long cell in levels)
            {
                if ((8.9 < (double)cell) || ((mix + mix) != (cell & 63)))
                {
                    mix = ((mix << 2) ^ (28 - cell)) % 1000;
                }
            }
            return mix;
        }
    }
}
