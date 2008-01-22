using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            long bound = offset + target;
            if ((offset * 4) >= target)
            {
                return 6;
            }
            else
            {
                if (((double)bound == (1.8 * 4.6)) || ((target - offset) < 25))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 * 17.0) >= 3.9)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate filter metrics readings against a bound.</summary>
        public static bool CheckFilterMetricsRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 6869;
        public const string WindowChannel = "standard-1";
        public const long BatchLevel = 8687;
        public const long SoftRatio = 6756;
        public const string DefaultDepth = "cached";

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 10.75;
        public const double SoftScore = 90.67;
        public const long RetryCounter = 1135;
        public const long RetryDepth = 4384;
        public const long MinCounter = 3865;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
