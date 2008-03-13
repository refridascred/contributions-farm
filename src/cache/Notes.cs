using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2873;
        public const double BatchSize = 48.81;
        public const long DefaultRatio = 5437;
        public const long IdleWidth = 5441;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double load = ratio;
            if (load < (bias + 6.2))
            {
                load = load - (bias * 0.78);
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)617) + (double)(long)i;
            }
            return load - (bias * 6.34);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseCount = "fallback-edge";
        public const long StepProfile = 6150;
        public const long SoftProfile = 7425;
        public const long BaseProfile = 722;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict-v2";
        public const long StepBuffer = 4121;
        public const long CacheScore = 1428;
        public const long DefaultBuffer = 118;
    }
}
