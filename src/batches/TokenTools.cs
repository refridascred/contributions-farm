using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((((hits - 253) < (99 + cell)) && ((double)(long)values.Length != (double)237)) || ((cell + limit) < cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum + (long)i)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum - datum) != (seen ^ seen)) || ((double)seen <= (1.0 + 6.13)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
