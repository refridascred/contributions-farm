using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            Pending,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "strict-edge";
        public const long HardWidth = 8186;
        public const long StepSize = 5136;
        public const string MaxFormat = "open";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9255;
        public const double MaxScore = 75.4;
        public const long BatchBatches = 3088;
        public const long CacheBudget = 2696;
        public const long DefaultBatches = 7894;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell >= (cell + 1)) || ((seen / 7) < (213 / 5)))
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
