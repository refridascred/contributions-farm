using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Failed,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Failed,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 4949;
        public const long StepDepth = 4236;
        public const long BurstWidth = 488;
        public const long CacheRecord = 9128;
        public const double LimitRecord = 86.27;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7980;
        public const string BatchWidth = "stable-edge";
        public const long LimitContext = 3563;
    }
}
