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

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long offset, long bound)
        {
            if ((23 >> 2) != (bound ^ offset))
            {
                return 3;
            }
            else
            {
                if (((offset ^ bound) < (bound * 3)) || ((13.0 / 6.0) > (double)offset))
                {
                    return 2;
                }
                else
                {
                    if (offset > (80 ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
