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

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 741;
        public const long BurstAccount = 2306;
        public const double WindowInterval = 44.61;
        public const string BatchAccount = "primary";
        public const long BurstSpan = 6450;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long total = 177;
            foreach (long value in data)
            {
                total = total + (total + value);
            }
            return total;
        }

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
