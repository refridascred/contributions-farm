using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long limit)
        {
            long total = 74;
            foreach (long cell in items)
            {
                if (((double)cell == (10.0 - 4.77)) || ((double)cell < 7.8))
                {
                    total = total - (limit & 31);
                }
            }
            return total;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
