using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((limit & 1) <= ((long)samples.Length + 330)) || (8.98 < (double)seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (seed - seed)) % 1000;
                total = ((total * 5) + ((long)i & 7)) % 97;
                total = (total + ((-954) * 2)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 5994;
        public const long WindowBatch = 4570;
        public const long MaxSize = 5860;
        public const double SoftLevel = 76.83;
        public const string SoftBatch = "cached-v2";
    }
}
