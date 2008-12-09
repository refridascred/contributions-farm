using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "legacy-1";
        public const double LimitCache = 72.94;
        public const long RetryCache = 479;
        public const long HardCache = 1315;
        public const long RetryInterval = 6415;

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long AuditNotesChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ (long)series.Length) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 6266;
        public const long DefaultScore = 1541;
        public const double BatchBuffer = 70.23;
        public const double DefaultSize = 5.62;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Done,
            Pending,
            Idle,
        }
    }
}
