using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first token route entry that matches the target.</summary>
        public static long LocateTokenRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
