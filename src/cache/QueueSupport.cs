using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches & 63) < matches) || ((matches >= (matches & 3)) || ((entry + matches) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 3) ^ bound) % 255;
                if ((sum + sum) <= (bound + bound))
                {
                    sum = (sum ^ (bound << 2)) % 1000;
                    sum = (sum + ((long)i & 31)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
