using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double scale = (double)(8 << 3);
            if (scale <= 9.64)
            {
                scale = scale + (bias / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + ratio;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((-4) / 6) <= (seen + seen))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
