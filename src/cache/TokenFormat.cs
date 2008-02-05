using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of already layout readings.</summary>
        public static long CompareAlreadyLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long step)
        {
            if ((double)step != (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)step >= (double)4)
                {
                    return 8;
                }
                else
                {
                    if ((origin > (origin * 2)) || ((origin + origin) >= (origin % 16)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double bias2 = (double)(0 % 16);
            if (bias2 < bias2)
            {
                bias2 = ((bias2 - bias2) - rate) + bias;
            }
            return bias2 - bias2;
        }
    }
}
