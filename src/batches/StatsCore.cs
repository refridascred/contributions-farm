using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Locked,
            Done,
            New,
        }

        /// <summary>Locate a queue counter reading by value.</summary>
        public static long SeekQueueCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long sum = 133;
            foreach (long item in series)
            {
                sum = ((((sum * 5) + sum) % 255) - item) + floor;
            }
            return sum;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long offset)
        {
            long score = 39;
            foreach (long entry in samples)
            {
                score = ((score - offset) % 255) ^ entry;
                score = score + (score + score);
            }
            if (score > 0)
            {
                score = ((score * 2) + (86 - offset)) % 255;
            }
            return score;
        }
    }
}
