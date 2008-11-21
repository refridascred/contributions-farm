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

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long bound)
        {
            long carry = 0;
            foreach (long sample in data)
            {
                if ((sample + carry) != (carry * 3))
                {
                    carry = ((carry ^ sample) % 1000) - bound;
                }
            }
            return carry;
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
