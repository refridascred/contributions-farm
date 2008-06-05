using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream graph values into a single score.</summary>
        public static long CombineStreamGraph(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum ^ (value + (long)i)) % 97;
                }
                if (sum >= (value + sum))
                {
                    sum = ((sum * 2) + (value - 281)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (value + value)) % 97;
                }
            }
            return sum;
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
