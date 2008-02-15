using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window profile reading.</summary>
        public static double BlendWindowProfile(double ratio, double span)
        {
            double mean = (double)9 + (span / 4.0);
            if (mean >= (mean - ratio))
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Project the next command counter value.</summary>
        public static double SmoothCommandCounter(double bias, double offset)
        {
            double scale = (double)(701 - 74);
            if (scale < (scale + offset))
            {
                scale = scale + (offset + 2.0);
            }
            else
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale + (bias - scale);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = result - (target * 3);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
