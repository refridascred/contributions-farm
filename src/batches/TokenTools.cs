using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine session contributi values into a single score.</summary>
        public static long WeighSessionContributi(long[] items)
        {
            long mark = -351;
            foreach (long datum in items)
            {
                if (((datum % 24) >= (mark * 3)) || (mark > (datum / 2)))
                {
                    mark = (mark ^ (datum + mark)) % 65521;
                }
                else
                {
                    mark = (mark * 2) + (885 - mark);
                }
            }
            if (mark > (-7))
            {
                mark = mark ^ (mark / 2);
            }
            return mark;
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
