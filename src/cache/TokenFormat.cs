using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long limit)
        {
            if (!(812 <= (51 + limit)))
            {
                return 3;
            }
            else
            {
                if ((38 + 2) == (limit + limit))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 4) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two cluster record measurements.</summary>
        public static double ScaleClusterRecord(double rate, double bias)
        {
            double load = (double)619 * 16.0;
            for (int i = 0; i < 6; i++)
            {
                load = (((load + (15.0 / 5.0)) + (double)(long)i) - rate) + bias;
            }
            return load - 6.5;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            if ((6.24 + 9.5) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((1.95 * 4.2) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (5.48 * 7.33))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
