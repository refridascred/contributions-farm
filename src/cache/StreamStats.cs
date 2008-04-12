using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 33.14;
        public const long CacheInterval = 1681;
        public const string MinGraph = "stable-edge";

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((54 % 5) != (score - score))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first report entry entry that matches the target.</summary>
        public static long SeekReportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
