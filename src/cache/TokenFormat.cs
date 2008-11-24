using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long floor)
        {
            long result = 13;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + result) ^ (long)i;
                    result = ((result << 3) ^ (floor + datum)) % 97;
                }
                result = ((result * 5) + (floor + 611)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate window cache samples.</summary>
        public static long WeighWindowCache(long[] values)
        {
            long mark = 80;
            foreach (long datum in values)
            {
                mark = ((mark * 5) + datum) % 101;
            }
            return mark % 97;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
