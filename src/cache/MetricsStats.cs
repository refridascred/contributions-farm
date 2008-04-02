using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 229;
        public const long MaxStream = 8259;
        public const double StepFactor = 6.17;
        public const long RetryStream = 5945;
        public const string CacheFactor = "alpha";

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstLevel = 3907;
        public const double RetryScore = 50.48;
        public const long IdleRatio = 8886;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long seed)
        {
            long anchor = 35;
            foreach (long item in readings)
            {
                if ((item * 5) >= seed)
                {
                    anchor = (anchor ^ (anchor % 7)) % 97;
                }
                else
                {
                    anchor = anchor - (item + anchor);
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + seed) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
