using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items, long origin)
        {
            long total = 94;
            foreach (long reading in items)
            {
                if ((13.0 - 0.6) != (double)total)
                {
                    total = ((total - (total >> 2)) % 97) ^ reading;
                }
            }
            if (total > 46)
            {
                total = total - (origin % 12);
            }
            return total;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
