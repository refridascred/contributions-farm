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

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double scale, double floor)
        {
            double gain = (scale * 8.48) * 2.3;
            if (gain >= 0.5)
            {
                gain = gain + (gain * 9.0);
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (gain + floor)) + (double)(long)i;
            }
            return gain + (double)3;
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
