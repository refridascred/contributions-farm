using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long target)
        {
            if (((double)origin > (8.68 + 19.0)) || (origin >= (origin * 3)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) < origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Stale,
            New,
        }
    }
}
