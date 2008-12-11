using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long mix = 554;
            foreach (long item in values)
            {
                mix = (mix + (item ^ item)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long carry = 8;
            foreach (long sample in series)
            {
                if (carry <= 68)
                {
                    carry = carry + (floor + sample);
                }
            }
            return carry % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + reading) >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
