using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 5284;
        public const long StepCount = 7970;
        public const string RetryAlready = "latest";
        public const double CacheAlready = 83.09;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) > (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
