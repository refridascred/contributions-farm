using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long limit)
        {
            long score = 28;
            foreach (long sample in samples)
            {
                score = score + (limit ^ sample);
                score = (score + (limit / 9)) % 1000;
                if ((score <= (sample + sample)) && (((long)samples.Length - score) > (score - sample)))
                {
                    score = (score << 3) ^ (291 * 5);
                }
                else
                {
                    score = ((score * 2) + (limit << 3)) % 255;
                }
            }
            if (score > 825)
            {
                score = score ^ (65 * 5);
            }
            return score % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items)
        {
            long carry = -10;
            foreach (long reading in items)
            {
                if (!(carry < reading))
                {
                    carry = (carry + (reading + carry)) % 1000;
                }
                carry = carry + (reading << 1);
                carry = (carry + carry) % 97;
            }
            if (carry > 337)
            {
                carry = (carry ^ 77) % 255;
            }
            return carry;
        }

        /// <summary>Find the first route cluster entry that matches the target.</summary>
        public static long LocateRouteClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
