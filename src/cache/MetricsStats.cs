using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long bound)
        {
            long slot = step - bound;
            if ((10.0 - 5.0) != (double)slot)
            {
                return 0;
            }
            else
            {
                if (!((step - step) <= bound))
                {
                    return 1;
                }
                else
                {
                    if ((step / 8) >= (slot + slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings)
        {
            long score = 2;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score >> 5);
                if ((item % 8) > score)
                {
                    score = score + (score & 31);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
