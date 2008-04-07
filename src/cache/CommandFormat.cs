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

        /// <summary>Roll a payload report counter forward.</summary>
        public static long SeriesPayloadReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (total >> 4);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
