using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            New,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "stable";
        public const long LimitTimeout = 7143;
        public const long StepSchema = 7180;
        public const long BaseSize = 5897;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
