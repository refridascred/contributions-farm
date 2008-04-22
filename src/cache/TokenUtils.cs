using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] samples)
        {
            long anchor = 16;
            foreach (long datum in samples)
            {
                if ((anchor ^ 52) <= (anchor + anchor))
                {
                    anchor = (((anchor * 5) + (anchor & 15)) % 65521) ^ datum;
                }
            }
            if (anchor < 728)
            {
                anchor = (anchor - (213 + anchor)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a stats session sample.</summary>
        public static long FindStatsSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double load = (double)(-164) * 12.0;
            if (load >= (double)97)
            {
                load = (load - (13.0 - load)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
