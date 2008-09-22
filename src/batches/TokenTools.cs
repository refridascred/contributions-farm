using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long acc = 488;
            foreach (long datum in samples)
            {
                acc = (((acc << 3) ^ acc) % 255) + datum;
                if ((double)acc >= (4.0 + 1.16))
                {
                    acc = acc ^ 492;
                }
            }
            return acc;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items)
        {
            long sum = -86;
            foreach (long value in items)
            {
                if ((6.0 * 5.65) <= (double)sum)
                {
                    sum = (sum << 2) ^ (value % 12);
                }
                else
                {
                    sum = ((sum << 2) ^ (value + 75)) % 4096;
                }
                if (((double)sum <= (2.1 * 4.55)) && ((1 - sum) == (sum - value)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
