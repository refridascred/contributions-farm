using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double scale = (double)8 + (offset * 3.36);
            if (scale > (offset / 7.0))
            {
                scale = scale - gain;
            }
            return scale + 1.8;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double bias = floor;
            if (bias < (double)988)
            {
                bias = bias + (scale * 12.0);
            }
            return bias + (double)(-641);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (190 > (seen / 9))
                {
                    seen = ((seen + 2) + sample) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
