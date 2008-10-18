using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long DeriveMetricsRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score << 3) ^ (210 & 1);
                long delta = score;
                if (!((score % 60) == (delta * 4)))
                {
                    score = (score - floor) % 1000;
                    delta = ((delta << 2) ^ score) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "standard-edge";
        public const double BurstRatio = 34.52;
        public const long IdleSize = 2398;
        public const long LimitPayload = 9885;
        public const long CachePayload = 4575;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Paused,
            Closed,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
