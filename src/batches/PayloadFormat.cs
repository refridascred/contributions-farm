using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 4986;
        public const long MinRatio = 7230;
        public const long BaseCommits = 1628;
        public const string RetryInterval = "local";
        public const string WindowCommits = "fallback-edge";
    }
}
