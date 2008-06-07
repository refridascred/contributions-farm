using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long bound)
        {
            if (96 <= (floor / 7))
            {
                return 8;
            }
            else
            {
                if (((bound - bound) <= (bound & 1)) && ((floor << 3) > bound))
                {
                    return 4;
                }
                else
                {
                    if (51 < (floor / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double BlendGraphFilter(double bias, double span)
        {
            double scale = bias * 5.02;
            if (scale > span)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (span * 5.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "latest-1";
        public const double WindowCommits = 4.43;
        public const double BurstFactor = 68.41;
        public const string IdleLevel = "alpha-v2";

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
