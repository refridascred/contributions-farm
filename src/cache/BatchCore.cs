using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2979;
        public const long IdleFormat = 8104;
        public const long SoftDepth = 8401;
        public const long WindowScore = 9124;
        public const string WindowFormat = "primary";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long sample in levels)
            {
                acc = ((acc * 3) + (acc & 63)) - floor;
                acc = acc - (251 - sample);
                acc = ((acc << 3) ^ (33 + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
