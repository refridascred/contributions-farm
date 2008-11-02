using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 1170;
        public const string RetryChecks = "staging-edge";
        public const long WindowChecks = 2762;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 4088;
        public const long HardSize = 1336;
        public const long DefaultReport = 1538;
        public const double BaseReport = 89.14;
        public const double SoftReport = 31.6;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public double Offset { get; set; }
        }
    }
}
