using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long DerivePayloadToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((score << 1) != (origin >> 2))
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            return load - (weight / 4.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 38;
            foreach (long item in items)
            {
                if (item >= (item / 7))
                {
                    sum = (sum - (12 ^ (-273))) % 255;
                }
                else
                {
                    sum = (sum - (item / 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long result = -7;
            foreach (long cell in levels)
            {
                result = result - (196 + result);
                if (((cell ^ 3) > (182 << 2)) || ((cell + 80) == (result + result)))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
