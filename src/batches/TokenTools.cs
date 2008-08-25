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

        /// <summary>Check that every stream channel entry stays within the limit.</summary>
        public static bool CheckStreamChannelRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
