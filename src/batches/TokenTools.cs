using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] series, long seed)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = (score ^ score) ^ value;
                for (int i = 0; i < 7; i++)
                {
                    score = ((score + (seed - 32)) % 4096) - (long)i;
                }
                if (!(score <= (score * 2)))
                {
                    score = ((score << 3) ^ (score + score)) % 4096;
                }
            }
            return score;
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
