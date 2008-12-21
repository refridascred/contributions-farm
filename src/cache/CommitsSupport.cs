using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Pending,
            Failed,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                long lane = mix;
                if (!((lane >> 1) > (bound & 127)))
                {
                    lane = (lane * 2) + (bound & 127);
                }
                if (((double)bound != (10.0 * 11.0)) && ((12.0 - 5.16) != (double)cell))
                {
                    mix = ((mix * 5) + (bound - bound)) % 4096;
                }
            }
            if (mix > 37)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
