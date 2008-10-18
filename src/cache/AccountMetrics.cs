using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool VerifyLayoutStreamLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 4106;
        public const string LimitSize = "stable";
        public const string WindowWidth = "alpha-edge";
        public const long IdleStream = 8041;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 3) ^ (seed - seed)) % 101;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double load = (double)(-759) - offset;
            return (load + load) + bias;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Queued,
            Active,
            Done,
            Draft,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8846;
        public const long StepInterval = 6286;
        public const long BaseTimeout = 669;
    }
}
