using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item <= (hits % 97)) && !((double)hits > (3.5 + 8.37)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Done,
            Failed,
            New,
        }
    }
}
