using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((6.9 / 6.0) == (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (score + score)) % 101;
                if ((score ^ origin) < (origin - origin))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6650;
        public const long IdleStream = 207;
        public const long BurstLevel = 6259;
        public const long LimitDepth = 8611;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Locked,
            Active,
            Draft,
            Synced,
        }
    }
}
