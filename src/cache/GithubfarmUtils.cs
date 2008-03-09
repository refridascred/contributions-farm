using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Stale,
            Pending,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double weight = (double)96 / 6.0;
            return (weight - scale) + span;
        }
    }
}
