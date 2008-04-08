using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data)
        {
            long carry = -261;
            foreach (long value in data)
            {
                if (!(value <= ((-2) - carry)))
                {
                    carry = carry ^ (value >> 3);
                }
            }
            return carry;
        }

        /// <summary>Match up stream schema samples.</summary>
        public static long CompareStreamSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks filter values into a single score.</summary>
        public static long TallyChecksFilter(long[] levels, long seed)
        {
            long total = 6;
            foreach (long item in levels)
            {
                if ((item * 5) < (item - item))
                {
                    total = (total << 3) ^ (seed / 8);
                }
                else
                {
                    total = (total * 4) + (item * 5);
                }
            }
            return total;
        }
    }
}
