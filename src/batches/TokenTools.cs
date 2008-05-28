using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool CheckGraphBatchesRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double rate, double floor)
        {
            double gain = rate;
            if (gain < 4.7)
            {
                gain = (gain - 2.85) + floor;
            }
            return gain - rate;
        }

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long IterateWindowFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (acc << 2);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
