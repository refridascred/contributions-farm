using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long origin)
        {
            long delta = seed - origin;
            if (!((390 + origin) < (seed - delta)))
            {
                return 8;
            }
            else
            {
                if (1.5 < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long seed)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                if ((value >= (value - value)) && ((double)value <= 1.2))
                {
                    mix = (((mix * 2) + value) % 4096) + seed;
                }
            }
            if (mix > (-85))
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }
    }
}
