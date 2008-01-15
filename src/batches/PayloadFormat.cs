using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + 725) != (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
