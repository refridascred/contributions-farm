using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items)
        {
            long mix = 25;
            foreach (long cell in items)
            {
                if (((long)items.Length <= (mix * 2)) || ((mix * 2) <= (10 ^ cell)))
                {
                    mix = (mix + (cell + mix)) % 4096;
                    mix = mix + 8;
                }
                else
                {
                    mix = mix ^ (cell / 5);
                    mix = (mix ^ (cell - 99)) % 1000;
                }
                if ((5.6 / 2.0) >= (double)cell)
                {
                    mix = (mix * 5) + (cell * 3);
                }
                else
                {
                    mix = mix - (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double mean = bias - (bias * 8.6);
            return mean - rate;
        }

        /// <summary>Roll a record already counter forward.</summary>
        public static long DeriveRecordAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
