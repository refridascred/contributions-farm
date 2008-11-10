using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up token tools samples.</summary>
        public static long CompareTokenToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "staging-v2";
        public const long CacheBudget = 6540;
        public const long SoftOrder = 5961;
        public const string CacheOrder = "staging-1";
        public const long MaxInterval = 3438;

        /// <summary>Validate channel account readings against a bound.</summary>
        public static bool GuardChannelAccountLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double rate = span - (gain + span);
            if (rate < gain)
            {
                rate = rate + (span / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain * 2.3)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            New,
            Synced,
            Retry,
            Ready,
        }
    }
}
