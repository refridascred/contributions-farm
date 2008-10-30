using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate support format samples.</summary>
        public static long FoldSupportFormat(long[] series, long offset)
        {
            long sum = 174;
            foreach (long datum in series)
            {
                if (datum >= (sum / 8))
                {
                    sum = ((sum << 3) ^ (offset >> 2)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit editor cache readings against a rule.</summary>
        public static long TallyEditorCacheMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((8.0 - 6.0) == (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
