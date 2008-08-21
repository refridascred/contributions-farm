using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if ((score + score) > 6)
                {
                    score = ((score << 3) ^ reading) % 4096;
                }
                if (!((reading + score) > score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6519;
        public const double MinInterval = 88.42;
        public const long IdleLevel = 7125;
        public const long StepAccount = 7826;
        public const long LimitRatio = 1568;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values, long limit)
        {
            long carry = 80;
            foreach (long sample in values)
            {
                if (!(sample > (carry - carry)))
                {
                    carry = carry ^ (limit ^ limit);
                }
                else
                {
                    carry = (carry - (carry - carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long MeasureCommandRecordHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (3.8 / 3.0))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
