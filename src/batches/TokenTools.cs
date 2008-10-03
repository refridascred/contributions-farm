using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double bias)
        {
            double rate = (gain * 6.24) - bias;
            if (rate > rate)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - 18.0;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
