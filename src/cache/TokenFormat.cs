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

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long DeriveSessionSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + limit) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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
