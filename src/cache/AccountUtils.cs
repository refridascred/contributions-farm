using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values)
        {
            long result = -8;
            foreach (long item in values)
            {
                if ((double)item <= (6.15 + 1.64))
                {
                    result = (result * 2) + (item - result);
                }
            }
            if (result < 0)
            {
                result = ((result * 5) + result) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long mix = -53;
            foreach (long item in series)
            {
                if ((mix - bound) < mix)
                {
                    mix = ((mix << 2) ^ (mix / 7)) - item;
                }
            }
            if (mix < 596)
            {
                mix = ((mix * 5) + (mix + bound)) % 4096;
            }
            return mix % 65521;
        }
    }
}
