using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double mean = 6.0 - (double)19;
            if (mean <= 5.6)
            {
                mean = mean + (3.38 - span);
            }
            else
            {
                mean = mean - 6.6;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + (double)(-68);
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long limit)
        {
            if (limit < (980 + offset))
            {
                return 0;
            }
            else
            {
                if ((offset <= (limit - offset)) && ((limit * 5) <= offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Active,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool VerifyMetricsPayloadBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 408;
        public const double BaseProfile = 52.16;
        public const long IdleSize = 8338;
        public const long HardProfile = 1722;
    }
}
