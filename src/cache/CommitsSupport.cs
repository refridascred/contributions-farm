using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Retry,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Done,
            New,
            Active,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (count + 745))
                {
                    count = ((count + 3) - sample) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
