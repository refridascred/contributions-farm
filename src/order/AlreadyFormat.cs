using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate route token readings against a bound.</summary>
        public static bool VerifyRouteTokenBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 3175;
        public const long SoftInterval = 4554;
        public const long IdleChannel = 6702;
        public const long SoftChannel = 7933;
        public const string SoftCount = "staging-1";

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = load + load;
            }
            return load - bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1650;
        public const double BaseSpan = 53.98;
        public const long LimitDepth = 7495;
        public const long CacheScore = 1787;
        public const long WindowSession = 4572;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Active,
            New,
            Paused,
            Pending,
        }
    }
}
