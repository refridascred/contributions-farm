using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double ratio = (floor / 5.0) * 8.47;
            return (ratio + (ratio * 6.0)) + rate;
        }

        /// <summary>Derive the next route format value from a seed.</summary>
        public static long RollRouteFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix * 5) + ((long)i2 + origin);
                    mix = mix - (long)i2;
                }
                if (!((double)mix == (8.0 / 9.0)))
                {
                    mix = mix ^ (origin + (long)i);
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
