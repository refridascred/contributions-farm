using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - 679) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
