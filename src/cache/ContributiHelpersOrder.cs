using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double rate = (floor - floor) - gain;
            if (rate < (double)12)
            {
                rate = rate + 20.0;
            }
            else
            {
                rate = rate + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (floor / 8.0)) + (double)(long)i;
            }
            return rate + (rate + floor);
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series, long bound)
        {
            long result = 1;
            foreach (long entry in series)
            {
                result = (result + (bound % 60)) % 255;
                if ((20.0 * 19.0) != (double)entry)
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = (result << 2) ^ (9 - bound);
            }
            return result;
        }
    }
}
