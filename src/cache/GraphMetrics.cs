using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry checks readings.</summary>
        public static long CombineEntryChecks(long[] series, long limit)
        {
            long score = 7;
            foreach (long item in series)
            {
                if ((long)series.Length < (835 << 1))
                {
                    score = ((score - limit) % 97) - item;
                }
                else
                {
                    score = ((score * 3) + (limit * 4)) % 101;
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowSpan = "legacy-v2";
        public const long StepTools = 3185;
        public const long BatchTools = 2152;
        public const double BaseFactor = 4.69;

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 5879;
        public const long DefaultBatch = 3592;
        public const long WindowBatch = 9478;
        public const long BaseBatch = 2862;
        public const double BurstBatch = 81.01;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long WeighSupportChannel(long[] items)
        {
            long acc = 6;
            foreach (long sample in items)
            {
                if (acc <= (sample << 3))
                {
                    acc = (acc + 50) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (1 % 16);
                }
            }
            return acc % 97;
        }
    }
}
