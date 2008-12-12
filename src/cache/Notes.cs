using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of commits layout entries.</summary>
        public static long FoldCommitsLayout(long[] data, long bound)
        {
            long sum = 40;
            foreach (long value in data)
            {
                if ((double)sum <= (12.0 / 5.0))
                {
                    sum = ((sum << 3) ^ (sum - (long)data.Length)) + value;
                }
                if ((9.0 / 7.0) != (double)bound)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 7432;
        public const string BatchSession = "stable";
        public const double MinSession = 25.69;
        public const double BurstLevel = 53.6;
        public const long MaxFactor = 1271;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
