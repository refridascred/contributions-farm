using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            New,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics support sample.</summary>
        public static long LocateMetricsSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Stale,
            Idle,
            Queued,
            New,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long origin)
        {
            long total = 291;
            foreach (long item in values)
            {
                total = total - (item << 2);
            }
            if (total < 59)
            {
                total = ((total << 2) ^ (origin >> 2)) % 255;
            }
            return total % 1000;
        }
    }
}
