using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) <= matches)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((8.0 / 3.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (offset2 <= bound)
                {
                    return 1;
                }
                else
                {
                    if (bound > (offset2 & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
