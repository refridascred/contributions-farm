using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "open-1";
        public const long DefaultNotes = 7231;
        public const long IdleFactor = 5684;
        public const long BurstSpan = 3330;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Closed,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] data)
        {
            long score = 5;
            foreach (long reading in data)
            {
                score = ((score ^ score) % 1000) - reading;
            }
            if (score < 61)
            {
                score = ((score << 3) ^ (score + 408)) % 65521;
            }
            return score % 1000;
        }
    }
}
