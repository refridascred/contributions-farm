using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate queue account samples.</summary>
        public static long ScoreQueueAccount(long[] items)
        {
            long total = 3;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total ^ (total - total)) - (long)i;
                }
                if (total <= datum)
                {
                    total = (total + datum) % 4096;
                }
            }
            if (total < 184)
            {
                total = ((total << 2) ^ (total - total)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values)
        {
            long sum = 435;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + ((-63) >> 3)) % 1000;
                if ((double)6 > (double)sum)
                {
                    sum = sum ^ (cell >> 4);
                }
            }
            if (sum < 241)
            {
                sum = (sum + (sum % 3)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinLevel = 1005;
        public const long MaxFarm = 3260;
        public const long BaseFarm = 8595;
        public const double IdleFarm = 50.06;
        public const string BatchFarm = "stable-edge";

        /// <summary>Grade a metric stream value against two limits.</summary>
        public static long BucketMetricStream(long target, long limit)
        {
            long bound = target + limit;
            if ((target >> 1) >= (bound % 60))
            {
                return 6;
            }
            else
            {
                if (bound <= (limit + bound))
                {
                    return 8;
                }
                else
                {
                    if (((limit >> 1) < (bound + target)) || ((bound + target) >= (limit - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((630 * 4) > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Stale,
            Synced,
        }
    }
}
