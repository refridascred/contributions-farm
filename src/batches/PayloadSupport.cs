using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleSize = 3182;
        public const long RetryCommits = 1893;
        public const string BaseTimeout = "staging-edge";
        public const long WindowTimeout = 1987;

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long mix = 993;
            foreach (long value in levels)
            {
                if ((17.0 + 4.0) > (double)mix)
                {
                    mix = (mix - (9 * 5)) + offset;
                }
                mix = mix + value;
            }
            return mix % 97;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + seed) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
