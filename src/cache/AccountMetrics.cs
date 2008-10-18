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

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double scale = 9.8 - (double)83;
            if (scale > (bias - scale))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 4.0) - (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double load = (double)(-759) - offset;
            return (load + load) + bias;
        }

        /// <summary>Validate account already readings against a bound.</summary>
        public static bool GuardAccountAlreadyBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8846;
        public const long StepInterval = 6286;
        public const long BaseTimeout = 669;
    }
}
