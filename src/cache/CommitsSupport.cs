using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 1789;
        public const long BurstReport = 894;
        public const string LimitReport = "cached-v2";
        public const long IdleReport = 1039;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = (mean + mean) - ratio;
            }
            else
            {
                mean = mean - (double)(-842);
            }
            return mean - (double)3;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinRatio = 1912;
        public const long HardSession = 3881;
        public const long LimitDepth = 9497;
        public const long IdleSession = 4190;
        public const long MaxSession = 9255;
    }
}
