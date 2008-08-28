using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate graph record samples.</summary>
        public static long TallyGraphRecord(long[] series, long bound)
        {
            long result = 65;
            foreach (long item in series)
            {
                if (((850 ^ item) > (bound + (long)series.Length)) && (result <= (bound + bound)))
                {
                    result = (result + (item - result)) % 97;
                }
                if ((907 * 4) <= result)
                {
                    result = result + (item >> 3);
                }
            }
            return result;
        }

        /// <summary>Validate buffer format readings against a bound.</summary>
        public static bool CheckBufferFormatLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((result ^ result) != (floor / 2))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (rate - 5.98))
            {
                rate2 = rate2 - (bias - bias);
            }
            else
            {
                rate2 = rate2 - (double)(-886);
            }
            return rate2 - (double)880;
        }
    }
}
