using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long origin)
        {
            if (566 >= (floor + origin))
            {
                return 4;
            }
            else
            {
                if ((47 + floor) >= origin)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin < 6.0) || ((double)origin <= (6.7 * 19.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result ^ step) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
