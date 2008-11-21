using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((offset - seed) < offset2)
            {
                return 7;
            }
            else
            {
                if ((4.3 - 8.65) >= (double)offset2)
                {
                    return 2;
                }
                else
                {
                    if (6 < seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 >= offset) || ((offset & 1) > 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context stream figure with a bias.</summary>
        public static double SmoothContextStream(double scale, double offset)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + scale;
            }
            return drift + (offset * 7.28);
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
