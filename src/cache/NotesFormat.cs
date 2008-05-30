using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            New,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "local";
        public const long LimitSize = 1651;
        public const long MinRecord = 1378;
        public const long BatchLevel = 8124;
        public const long MinInterval = 7757;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + offset) != (datum - offset)) && ((1.61 / 6.0) >= (double)offset))
                {
                    seen = seen + 3;
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
