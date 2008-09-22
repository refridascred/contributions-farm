using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double scale = (gain + floor) - gain;
            return scale - floor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double scale = span - (0.8 * 0.79);
            return (scale + (0.9 * 4.0)) + ratio;
        }
    }
}
