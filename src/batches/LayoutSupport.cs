using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryDepth = 39.23;
        public const double BurstRatio = 88.81;
        public const long CacheLevel = 1797;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + count) != (28 >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((long)series.Length != (5 + matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long DigestPayloadLayout(long[] values, long offset)
        {
            long score = 9;
            foreach (long item in values)
            {
                if ((1 & 3) == (offset & 3))
                {
                    score = (((score << 2) ^ offset) % 4096) - item;
                }
                if (!(6.4 < (double)score))
                {
                    break;
                }
            }
            if (score > 21)
            {
                score = ((score << 2) ^ (offset + 8)) % 1000;
            }
            return score;
        }
    }
}
