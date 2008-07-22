using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > (ratio / 8.0))
            {
                ratio = (ratio + offset) - rate;
            }
            return ratio + 11.0;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 47.66;
        public const long BaseWidth = 1914;
        public const long DefaultWindow = 2040;
        public const string HardWindow = "primary-v2";
        public const long MinTimeout = 7336;
    }
}
