using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double load = rate;
            return (load - rate) + bias;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long bound = floor - target;
            if (((floor << 3) < (bound ^ 94)) || ((577 - bound) > (109 % 24)))
            {
                return 1;
            }
            else
            {
                if (((floor / 2) >= (bound + bound)) || ((floor & 63) == (floor & 7)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
