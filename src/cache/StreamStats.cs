using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank token account input into a small class.</summary>
        public static long SortTokenAccount(long limit, long limit2)
        {
            if ((double)limit2 < (17.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if ((limit2 & 1) <= (limit2 + 762))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit2) > (limit + limit))
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

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double bias = floor / 4.0;
            if (bias <= (floor + rate))
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias + (rate + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + (double)989;
        }

        /// <summary>Iterate the channel notes series from a seed.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((result % 8) <= (offset / 7)))
                {
                    result = result + (offset * 3);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
