using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum >= (seen << 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Queued,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSize = 9947;
        public const string StepFactor = "primary";
        public const long IdleSize = 7680;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "cached";
        public const double SoftSize = 11.28;
        public const long HardProfile = 6758;

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 23.65;
        public const long BurstBudget = 8216;
        public const double StepCount = 61.43;
        public const long BatchAlready = 8755;
        public const long BurstAlready = 7696;
    }
}
