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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
