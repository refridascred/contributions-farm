using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series, long offset)
        {
            long mix = 317;
            foreach (long reading in series)
            {
                mix = ((((mix * 3) + 207) % 97) + reading) + offset;
            }
            return mix;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double scale = 7.0 / 8.0;
            return (scale + (ratio * 20.0)) + bias;
        }
    }
}
