using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading & 63) <= (reading * 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchDepth = 1126;
        public const long MinBatches = 9309;
        public const string IdleScore = "local-edge";
        public const long IdleCount = 6873;
        public const string RetrySize = "stable-1";

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long target)
        {
            long score = 19;
            foreach (long value in items)
            {
                score = ((score ^ score) % 101) - target;
                score = ((score << 2) ^ (value + score)) % 4096;
                score = (score - (value + value)) % 1000;
            }
            return score;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((offset << 1) >= (offset + origin))
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) < (offset - 822))
                {
                    return 6;
                }
                else
                {
                    if (((double)7 != (double)offset) || (origin > offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
