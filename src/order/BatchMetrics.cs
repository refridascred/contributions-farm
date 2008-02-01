using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Iterate the stats already series from a seed.</summary>
        public static long DeriveStatsAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                long offset = state & 127;
                if ((offset & 7) > (limit ^ limit))
                {
                    break;
                }
                offset = ((offset << 3) ^ ((long)i + state)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine contributi layout values into a single score.</summary>
        public static long FoldContributiLayout(long[] items, long target)
        {
            long acc = 693;
            foreach (long value in items)
            {
                if ((value - value) > target)
                {
                    acc = (acc ^ (value * 5)) % 255;
                }
            }
            if (acc < 205)
            {
                acc = (acc * 5) + (target + acc);
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "standard-edge";
        public const string RetrySession = "fallback";
        public const long CacheRatio = 6400;
        public const long RetryInterval = 8116;
        public const double LimitSession = 62.59;
    }
}
