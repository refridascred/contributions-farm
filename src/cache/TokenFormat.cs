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

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((14.0 / 7.0) == (double)bound)
                {
                    score = (score - (bound / 8)) % 1000;
                    score = ((score * 3) + (bound + (long)i)) % 4096;
                }
                else
                {
                    score = (score << 2) ^ bound;
                    score = ((score << 3) ^ (score & 127)) % 65521;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
