using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 4796;
        public const string RetryWidth = "latest-1";
        public const long WindowToken = 2531;
        public const string HardTimeout = "legacy-edge";
        public const string StepToken = "fallback-edge";

        /// <summary>Rank contributi stats input into a small class.</summary>
        public static long ClassifyContributiStats(long limit, long floor)
        {
            long slot = limit - floor;
            if ((limit + 90) > (limit << 2))
            {
                return 4;
            }
            else
            {
                if (!((limit & 127) >= (35 / 5)))
                {
                    return 3;
                }
                else
                {
                    if (((slot % 12) > limit) && (limit < (limit & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool GuardMetricsAlreadyLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
