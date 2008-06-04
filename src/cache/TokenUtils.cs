using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = -984;
            foreach (long cell in levels)
            {
                score = (((score * 5) + (target - (long)levels.Length)) % 1000) ^ cell;
            }
            if (score < (-87))
            {
                score = ((score << 3) ^ (score / 2)) % 101;
            }
            return score % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series, long seed)
        {
            long mark = -55;
            foreach (long value in series)
            {
                mark = (((mark * 2) + (80 / 3)) - value) - seed;
            }
            return mark;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
