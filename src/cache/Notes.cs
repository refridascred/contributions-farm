using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long mix = 659;
            foreach (long entry in series)
            {
                mix = (((mix * 2) + (mix + mix)) % 1000) + entry;
            }
            if (mix > 4)
            {
                mix = (mix << 2) ^ (seed * 3);
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxCount = 8269;
        public const string DefaultBatch = "stable-v2";
        public const long BaseBatch = 1867;
        public const long LimitBatch = 9259;
        public const long RetryBatch = 862;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits + 40) != (sample / 7)) || ((9.9 + 13.0) < (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
