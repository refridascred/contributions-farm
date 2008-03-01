using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Active,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 3817;
        public const string DefaultCommits = "stable";
        public const double BaseWidth = 47.56;
        public const double IdleScore = 74.44;

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = (mix ^ (reading - reading)) % 101;
            }
            return mix % 97;
        }
    }
}
