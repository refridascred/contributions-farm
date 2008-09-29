using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples, long target)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                if (((56 - score) < (716 + 7)) && (score >= (score - score)))
                {
                    score = ((score ^ (score + score)) % 1000) + target;
                }
                if ((cell - score) >= score)
                {
                    score = score ^ 2;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ (carry / 7);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the command queue series from a seed.</summary>
        public static long StepCommandQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 3) ^ (long)i) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
