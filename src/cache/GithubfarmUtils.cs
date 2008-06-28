using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((origin + sample) <= (sample - sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 7059;
        public const long DefaultSchema = 8798;
        public const string StepSchema = "cached-edge";
        public const double BatchWidth = 4.61;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
