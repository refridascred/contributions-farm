using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = (double)(243 >> 1);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)877) - (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Project the next channel route value.</summary>
        public static double AdjustChannelRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift >= 9.3)
            {
                drift = drift + (double)74;
            }
            return drift + gain;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((298 & 127) <= (tally & 63)) && ((tally + tally) < 45)) && (((datum & 3) > tally) || (tally >= (64 % 7))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
