using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double mean = (double)(25 + 55);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (mean * 12.0)) + (double)(long)i) - rate;
            }
            return mean - bias;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format token figure with a bias.</summary>
        public static double BlendFormatToken(double scale, double floor)
        {
            double bias = 9.0;
            if (bias > scale)
            {
                bias = (bias + (double)1) + floor;
            }
            return bias - (double)696;
        }
    }
}
