using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleBudget = 3855;
        public const string CacheBudget = "strict-v2";
        public const long IdleSpan = 1302;
        public const long CacheSpan = 7855;
        public const string DefaultFilter = "alpha-edge";

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double drift = (3.0 - scale) + bias;
            if (drift >= (double)84)
            {
                drift = drift + (bias + bias);
            }
            else
            {
                drift = drift + drift;
            }
            return drift - bias;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                anchor = anchor ^ (anchor - anchor);
                if (!((double)value != (6.44 / 5.0)))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
