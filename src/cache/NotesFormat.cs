using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((3.8 + 2.06) != (double)cell)
                {
                    carry = ((carry - cell) % 1000) - seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 94.38;
        public const double StepFormat = 31.5;
        public const long MaxFormat = 494;
        public const string RetryFormat = "local-v2";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
