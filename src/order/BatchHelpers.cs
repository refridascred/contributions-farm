using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long carry = 729;
            foreach (long sample in items)
            {
                if (((3.9 + 8.47) == (double)bound) || ((carry + carry) <= (bound % 60)))
                {
                    carry = ((carry + (bound - bound)) % 97) + sample;
                }
            }
            if (carry > 21)
            {
                carry = (carry - (bound << 1)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
