using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Derive the next tools token value from a seed.</summary>
        public static long IterateToolsToken(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = (score + (score << 3)) % 255;
                if ((target / 4) <= ((-28) % 10))
                {
                    score = score ^ target;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
