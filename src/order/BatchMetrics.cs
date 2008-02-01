using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine queue stream values into a single score.</summary>
        public static long CombineQueueStream(long[] levels, long step)
        {
            long sum = -810;
            foreach (long datum in levels)
            {
                if ((sum + 0) > datum)
                {
                    sum = (((sum << 2) ^ sum) % 4096) + step;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ (sum >> 5);
            }
            return sum;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long CountProfileOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((54 * 5) < (value + value)) && ((value % 16) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "standard-edge";
        public const string RetrySession = "fallback";
        public const long CacheRatio = 6400;
        public const long RetryInterval = 8116;
        public const double LimitSession = 62.59;
    }
}
