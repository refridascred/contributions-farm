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

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double offset)
        {
            double gain2 = 4.39;
            if (gain2 <= gain)
            {
                gain2 = (gain2 - 5.4) - offset;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - (gain2 + gain);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Mode { get; set; }
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
