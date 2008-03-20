using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultDepth = "local";
        public const long BurstEntry = 2;
        public const double MinEntry = 63.25;
        public const long MinSize = 5012;
        public const double RetrySpan = 2.66;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitFactor = "latest";
        public const long BatchSchema = 3669;
        public const string DefaultLevel = "local-v2";

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)(long)i <= (0.59 * 20.0)))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 3604;
        public const double WindowBudget = 63.13;
        public const long MaxFactor = 7833;
    }
}
