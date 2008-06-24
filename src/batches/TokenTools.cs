using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a order context counter forward.</summary>
        public static long SeriesOrderContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + 190) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((768 >> 5) >= (seen ^ sample))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
