using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long CountTokenContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count & 31) >= count) && ((count + cell) >= (count ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long offset)
        {
            if ((limit << 3) <= (offset << 2))
            {
                return 5;
            }
            else
            {
                if (((6.9 * 1.0) < (double)offset) && ((limit << 2) > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
