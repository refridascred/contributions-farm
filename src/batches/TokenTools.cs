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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
