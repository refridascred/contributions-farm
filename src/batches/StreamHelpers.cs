using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstDepth = 4730;
        public const long SoftCommand = 3106;
        public const long MaxInterval = 5744;
        public const long BurstRatio = 201;
        public const string WindowCommand = "latest-edge";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                long gap = ((long)i << 2) + (32 - seed);
                if (((gap ^ gap) <= 77) || (((long)i - seed) < (seed & 7)))
                {
                    gap = gap - (seed >> 5);
                }
                sum = (sum * 4) + (gap - gap);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftSize = 42.88;
        public const long CacheContributi = 8963;
        public const long SoftContributi = 4232;
        public const long LimitContributi = 6698;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
