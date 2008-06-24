using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry channel measurements.</summary>
        public static double SmoothEntryChannel(double rate, double span)
        {
            double drift = span;
            if (drift < (rate / 8.0))
            {
                drift = drift + rate;
            }
            return drift + 8.9;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (span - 7.0))
            {
                scale = scale - (double)0;
            }
            return scale + span;
        }
    }
}
