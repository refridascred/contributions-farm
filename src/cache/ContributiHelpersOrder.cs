using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long seed)
        {
            if ((double)seed > (9.93 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((824 & 1) >= step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (0.9 * 15.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1667;
        public const long HardContext = 1341;
        public const long DefaultContext = 9376;
        public const double SoftContext = 84.85;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
