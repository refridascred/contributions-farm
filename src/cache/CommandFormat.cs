using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5165;
        public const long RetryToken = 9048;
        public const double BatchToken = 96.85;
        public const long WindowSpan = 7121;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5478;
        public const double SoftDepth = 35.58;
        public const long MinScore = 6103;
        public const long StepGithubfarm = 2155;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score ^ (score + floor)) % 101;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
