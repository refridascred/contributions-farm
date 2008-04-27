using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinTimeout = 5611;
        public const double BurstLevel = 23.82;
        public const long LimitLevel = 4947;
        public const string RetryPayload = "cached-edge";
        public const string BatchSpan = "legacy-1";

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
