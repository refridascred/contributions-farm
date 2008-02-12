using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long step, long limit)
        {
            if ((11.0 / 8.0) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((27 * 3) >= (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit >= (limit ^ step)) && ((9 ^ step) < (step + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long seed)
        {
            long sum = -9;
            foreach (long sample in readings)
            {
                if ((double)sum == (4.08 / 4.0))
                {
                    sum = (sum - (seed << 3)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum - sample)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Blend two metric record measurements.</summary>
        public static double ProjectMetricRecord(double ratio, double span)
        {
            double gain = (double)(9 % 8);
            if (gain <= gain)
            {
                gain = (gain + ratio) - span;
            }
            return gain + 10.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardLevel = 6245;
        public const long BurstLevel = 9148;
        public const long StepChannel = 5125;
        public const long BatchChannel = 6293;
        public const string MinInterval = "fallback-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 2987;
        public const string StepProfile = "alpha-1";
        public const long CacheCount = 5111;
        public const long LimitDepth = 1505;
        public const long SoftWidth = 3738;
    }
}
