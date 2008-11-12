using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values, long seed)
        {
            long acc = 94;
            foreach (long item in values)
            {
                acc = (acc ^ (seed << 1)) % 4096;
                if (!((acc - item) >= (seed >> 5)))
                {
                    acc = acc ^ (538 & 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool ValidateCacheMetricLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Idle,
            Done,
            New,
            Stale,
        }
    }
}
