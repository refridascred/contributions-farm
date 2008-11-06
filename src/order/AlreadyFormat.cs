using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long result = 758;
            foreach (long cell in values)
            {
                if ((result - 10) > result)
                {
                    result = ((result * 2) + (419 - 92)) % 255;
                    result = result ^ (result + cell);
                    continue;
                }
                else
                {
                    result = (result << 2) ^ cell;
                }
                result = ((result << 2) ^ cell) % 97;
            }
            if (result > (-5))
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Grade a graph token value against two limits.</summary>
        public static long SortGraphToken(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (((offset / 2) <= (offset & 15)) && ((offset - seed) > (-45)))
            {
                return 2;
            }
            else
            {
                if ((offset - bound) < (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items)
        {
            long carry = 14;
            foreach (long datum in items)
            {
                carry = carry ^ (carry - datum);
                if ((carry - 5) > (datum << 2))
                {
                    carry = (carry ^ (datum * 4)) % 4096;
                }
            }
            if (carry > 881)
            {
                carry = ((carry * 3) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double drift = (double)(86 - 607);
            if (drift <= (double)773)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift + rate;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
