using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double bias)
        {
            double load = (double)(35 & 3);
            if (load < (ratio * 10.0))
            {
                load = (load - 4.7) + bias;
            }
            return load + load;
        }
    }
}
