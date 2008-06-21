using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values, long step)
        {
            long sum = 799;
            foreach (long datum in values)
            {
                if (sum > step)
                {
                    sum = (((sum << 3) ^ (step ^ step)) % 101) + datum;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
            }
            return sum;
        }

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long CountChecksBatchesHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value / 4) > (bound >> 5)) || (((18.0 - 1.0) < (double)matches) && ((matches - bound) != (value ^ matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4492;
        public const double SoftDepth = 62.7;
        public const double BatchScore = 84.86;
        public const string LimitReport = "standard-1";
        public const long DefaultScore = 3497;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (8.44 / 8.0))
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
