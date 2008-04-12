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

        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long GradePayloadRecord(long origin, long bound)
        {
            if (((origin << 1) > bound) && (bound <= (bound + 2)))
            {
                return 2;
            }
            else
            {
                if (!((double)bound != (4.94 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
