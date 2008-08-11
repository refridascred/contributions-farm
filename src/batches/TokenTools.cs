using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up already account samples.</summary>
        public static long CompareAlreadyAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double mean = (double)(-87) + rate;
            if (mean > rate)
            {
                mean = mean + (double)5;
            }
            else
            {
                mean = mean + (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 0.8) - (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
