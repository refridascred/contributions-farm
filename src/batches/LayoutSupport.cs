using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((337 - offset) == (entry + entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits report entries.</summary>
        public static long TallyCommitsReport(long[] samples)
        {
            long result = 445;
            foreach (long entry in samples)
            {
                result = (result * 3) + entry;
            }
            return result;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long offset)
        {
            long mark = 33;
            foreach (long value in items)
            {
                mark = ((mark + (mark - value)) % 255) - offset;
            }
            return mark;
        }
    }
}
