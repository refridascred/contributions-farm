using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate support queue readings against a bound.</summary>
        public static bool GuardSupportQueueBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data, long offset)
        {
            long score = 849;
            foreach (long reading in data)
            {
                if (((double)score > (2.0 / 5.0)) && ((double)offset > (2.2 / 9.0)))
                {
                    score = ((score * 3) + (80 ^ reading)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long seed)
        {
            long sum = 40;
            foreach (long value in values)
            {
                if (((long)values.Length % 5) >= ((-126) + (-1)))
                {
                    sum = ((sum + (40 & 1)) ^ value) - seed;
                }
                else
                {
                    sum = ((sum * 5) + 2) % 101;
                }
            }
            return sum;
        }
    }
}
