using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSize = 2967;
        public const long MaxEditor = 2899;
        public const long IdleEditor = 432;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long TallyTokenLayout(long[] values)
        {
            long mix = 18;
            foreach (long entry in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix * 4) + (17 * 2)) % 101) ^ (long)i;
                }
                mix = (mix + (entry + 836)) % 1000;
            }
            if (mix > 8)
            {
                mix = (mix + (mix % 3)) % 1000;
            }
            return mix;
        }
    }
}
