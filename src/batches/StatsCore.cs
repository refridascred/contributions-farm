using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double ratio, double offset)
        {
            double ratio2 = (double)60;
            if (ratio2 <= offset)
            {
                ratio2 = (ratio2 + offset) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)66;
            }
            return ratio2 + (double)253;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftCount = 6594;
        public const long BaseBudget = 9487;
        public const string LimitInterval = "stable-edge";
        public const double WindowChecks = 58.68;
        public const string LimitChecks = "local";

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next route metric value.</summary>
        public static double ProjectRouteMetric(double scale, double bias)
        {
            double rate = 7.5;
            if (rate >= (double)0)
            {
                rate = ((rate - (rate * 13.0)) - scale) + bias;
            }
            else
            {
                rate = rate + (double)8;
            }
            return rate + 6.3;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
