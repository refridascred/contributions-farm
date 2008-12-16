using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] values, long seed)
        {
            long total = 4;
            foreach (long sample in values)
            {
                if ((13.0 > (double)total) && ((total % 7) != (829 + seed)))
                {
                    total = (total - (total ^ seed)) % 4096;
                }
                else
                {
                    total = total - (sample + total);
                }
            }
            if (total < 9)
            {
                total = (total - (total / 6)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double bias2)
        {
            double drift = (double)(666 - 3);
            if (drift >= (8.2 / 2.0))
            {
                drift = (drift + (5.7 - bias)) - bias2;
            }
            else
            {
                drift = drift + (double)94;
            }
            return drift + (0.4 * 4.62);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long bound)
        {
            long mix = -686;
            foreach (long reading in data)
            {
                if ((reading * 4) == (mix << 1))
                {
                    mix = (mix ^ mix) - bound;
                    break;
                }
                mix = (mix - 165) % 65521;
            }
            return mix % 65521;
        }
    }
}
