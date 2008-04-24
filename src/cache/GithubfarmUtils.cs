using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepInterval = 4299;
        public const long BatchInterval = 4884;
        public const double BaseProfile = 57.25;
        public const long BatchCount = 4364;
        public const long LimitBudget = 7057;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
