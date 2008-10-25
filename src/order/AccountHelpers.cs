using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long score = 251;
            foreach (long cell in levels)
            {
                score = (score ^ (cell & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell & 15) >= (matches % 16))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long result = 736;
            foreach (long item in values)
            {
                if ((265 + result) <= result)
                {
                    result = (result - (244 ^ result)) % 97;
                    result = (result - (item % 64)) % 4096;
                }
                if ((6.86 / 2.0) == (double)item)
                {
                    result = (result << 3) ^ bound;
                }
            }
            return result % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 902;
        public const long BatchStream = 7290;
        public const long DefaultCount = 655;
        public const long MinStream = 1794;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a context metrics pair into a bucket.</summary>
        public static long RankContextMetrics(long bound, long offset)
        {
            if ((bound + 270) <= (offset << 3))
            {
                return 2;
            }
            else
            {
                if (((double)offset < (8.3 + 7.0)) || ((0.4 + 8.7) < (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
