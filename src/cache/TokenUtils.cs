using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(560 >= ((long)items.Length / 7)))
                {
                    seen = ((seen + 2) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
