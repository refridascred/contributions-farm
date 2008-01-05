using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 39;
            foreach (long entry in levels)
            {
                if (((entry << 3) >= (mix * 5)) || ((12.0 / 5.0) == (double)mix))
                {
                    mix = mix ^ (entry + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long mark = 49;
            foreach (long cell in levels)
            {
                mark = (((mark * 2) + (mark & 7)) % 4096) ^ cell;
            }
            if (mark > 89)
            {
                mark = (mark - (mark * 4)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Blend two queue already measurements.</summary>
        public static double ScaleQueueAlready(double scale, double floor)
        {
            double bias = floor * 20.0;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias - floor)) - (double)(long)i;
            }
            return bias - (bias - scale);
        }
    }
}
