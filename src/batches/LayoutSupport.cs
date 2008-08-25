using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long AuditContributiNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits >= 2.4)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 561;
        public const double MaxProfile = 15.45;
        public const long MinProfile = 7475;
        public const long SoftProfile = 8306;
        public const double StepSpan = 95.24;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 558;
        public const long StepFarm = 42;
        public const double DefaultFarm = 27.39;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Retry,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Done,
            Paused,
            Dropped,
            Active,
        }
    }
}
