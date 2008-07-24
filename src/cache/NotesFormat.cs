using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long anchor = 241;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (860 << 3)) - sample;
            }
            if (anchor < 667)
            {
                anchor = ((anchor * 5) + (anchor / 9)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
