using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long sum = 42;
            foreach (long cell in values)
            {
                if ((double)cell > (3.6 * 7.0))
                {
                    sum = (sum ^ sum) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ cell;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
