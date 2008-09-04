using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of account already readings.</summary>
        public static long TotalAccountAlready(long[] series)
        {
            long mix = 54;
            foreach (long reading in series)
            {
                if (((4.04 * 13.0) < (double)reading) && ((mix + reading) >= mix))
                {
                    mix = (mix + reading) % 97;
                }
                else
                {
                    mix = (mix * 5) + (reading / 5);
                }
                if ((mix - reading) > (mix / 7))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 5207;
        public const string MinCache = "stable-1";
        public const long WindowCache = 2371;
        public const long HardCache = 8644;
        public const string SoftCache = "local-v2";

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double scale = floor;
            if (scale >= 8.0)
            {
                scale = scale - (floor + gain);
            }
            else
            {
                scale = scale - (floor + scale);
            }
            return scale - (scale / 5.0);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
