using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate channel schema samples.</summary>
        public static long FoldChannelSchema(long[] items, long target)
        {
            long score = -4;
            foreach (long item in items)
            {
                score = (((score * 5) + (score + 3)) % 101) - target;
                score = (score + (item & 255)) % 255;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "cached";
        public const double BatchContributi = 32.95;
        public const long SoftContributi = 6768;
        public const string BatchScore = "standard-v2";
        public const long HardContributi = 4696;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)(long)series.Length <= (5.6 / 8.0)) || ((523 ^ count) == (count >> 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
