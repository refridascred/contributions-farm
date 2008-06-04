using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long step)
        {
            long sum = 83;
            foreach (long item in levels)
            {
                sum = ((sum ^ 62) % 101) + item;
            }
            if (sum > 95)
            {
                sum = sum + (step % 10);
            }
            return sum;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long TallySupportNotes(long[] series)
        {
            long mark = 47;
            foreach (long sample in series)
            {
                mark = (((mark << 2) ^ (1 + mark)) % 65521) - sample;
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
