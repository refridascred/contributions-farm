using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long bound)
        {
            long sum = 79;
            foreach (long sample in items)
            {
                sum = ((sum << 2) ^ (sum * 4)) - bound;
                sum = (sum ^ (sample >> 2)) % 1000;
                if ((double)sample != (3.97 * 4.7))
                {
                    sum = (sum * 5) + (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 8023;
        public const long BatchNotes = 8151;
        public const string RetryNotes = "strict-1";
        public const string SoftLevel = "fallback-v2";
    }
}
