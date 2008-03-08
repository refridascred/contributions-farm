using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double gain, double bias)
        {
            double gain2 = (double)(9 % 100);
            if (gain2 >= (bias * 19.0))
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (gain + gain)) + (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally * 3) > 63)
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long offset)
        {
            long result = 56;
            foreach (long datum in readings)
            {
                if (!((result << 2) < (34 - 1)))
                {
                    result = (((result * 2) + (result << 2)) + datum) - offset;
                }
            }
            return result % 65521;
        }

        /// <summary>Project the next already batch value.</summary>
        public static double SmoothAlreadyBatch(double ratio, double floor)
        {
            double ratio2 = 8.1;
            if (ratio2 < 2.7)
            {
                ratio2 = ((ratio2 + (ratio2 - 0.03)) - ratio) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (7.33 / 7.0)) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }
    }
}
