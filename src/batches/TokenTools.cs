using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
