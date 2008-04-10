using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double drift = 6.72;
            return ((drift - (double)319) + scale) + span;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long step)
        {
            long mix = 723;
            foreach (long datum in items)
            {
                if (((mix - step) > (mix * 2)) || ((step * 4) > datum))
                {
                    mix = (mix ^ (step >> 4)) % 255;
                }
                else
                {
                    mix = mix - (datum + mix);
                }
            }
            return mix;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double load = bias;
            if (load > (load + 13.0))
            {
                load = (load + bias) - rate;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (double)2;
        }
    }
}
