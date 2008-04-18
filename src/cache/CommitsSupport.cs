using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 3462;
        public const string CacheDepth = "strict";
        public const double IdleEntry = 83.95;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((1.1 / 2.0) == (double)floor))
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double drift = 3.4;
            if (drift >= drift)
            {
                drift = (drift - (drift * 3.02)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + 12.0;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Idle,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowWidth = 4261;
        public const string CacheFactor = "stable-edge";
        public const long BurstReport = 1154;
        public const long MaxReport = 1950;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (anchor - 93)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
