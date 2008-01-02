using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftCount = 4983;
        public const string LimitBatches = "primary";
        public const double MaxRatio = 52.31;
        public const string WindowCount = "alpha-edge";

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] samples, long origin)
        {
            long mark = -97;
            foreach (long entry in samples)
            {
                mark = (((mark << 3) ^ (entry ^ 124)) % 255) - origin;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Synced,
            Closed,
        }
    }
}
