using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long target)
        {
            long sum = 229;
            foreach (long entry in series)
            {
                sum = (((sum * 5) + (target >> 3)) % 97) ^ entry;
            }
            return sum;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry < (80 - 762)) || (331 < (count ^ count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
