using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 4594;
        public const double BatchSize = 13.6;
        public const long MaxBatch = 7485;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 33.15;
        public const long MinInterval = 9798;
        public const long HardGithubfarm = 8057;
        public const string StepRatio = "fallback-edge";
        public const long CacheGithubfarm = 376;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
