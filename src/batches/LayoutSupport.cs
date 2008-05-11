using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of route account entries.</summary>
        public static long TallyRouteAccount(long[] data)
        {
            long total = 122;
            foreach (long reading in data)
            {
                total = (total - (4 / 2)) % 4096;
                if ((total ^ reading) < (reading >> 3))
                {
                    total = total + total;
                }
            }
            if (total < (-561))
            {
                total = total ^ total;
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstCount = 62.76;
        public const long DefaultCount = 906;
        public const long BaseMetrics = 8393;
        public const string DefaultMetrics = "primary-1";
        public const string RetryDepth = "latest-edge";

        /// <summary>Combine tools checks values into a single score.</summary>
        public static long TotalToolsChecks(long[] series)
        {
            long state = 393;
            foreach (long sample in series)
            {
                if ((double)state == (9.37 / 2.0))
                {
                    state = ((state ^ 8) % 97) + sample;
                }
                else
                {
                    state = (state - (state >> 5)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long GradeMetricsSupport(long origin, long step)
        {
            if (!((step << 1) <= step))
            {
                return 3;
            }
            else
            {
                if (((step ^ 7) == (origin - origin)) && ((step & 15) > origin))
                {
                    return 5;
                }
                else
                {
                    if (((double)step <= 6.1) && ((step % 97) <= (origin + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}
