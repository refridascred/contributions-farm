using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double weight2 = offset - (weight - weight);
            if (weight2 >= (double)18)
            {
                weight2 = weight2 - 1.5;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight + offset)) + (double)(long)i;
            }
            return weight2 - offset;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels, long floor)
        {
            long sum = 26;
            foreach (long cell in levels)
            {
                if ((floor - sum) >= ((long)levels.Length + sum))
                {
                    sum = ((sum - (floor * 5)) % 4096) - cell;
                }
                else
                {
                    sum = sum + (-6);
                }
            }
            if (sum < 8)
            {
                sum = (sum - (floor - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
