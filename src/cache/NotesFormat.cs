using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of commits report entries.</summary>
        public static long WeighCommitsReport(long[] samples)
        {
            long anchor = 754;
            foreach (long value in samples)
            {
                anchor = (anchor + (7 - anchor)) % 4096;
                if (value < (14 << 2))
                {
                    anchor = ((anchor << 2) ^ value) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
