using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                if ((169 + (-67)) <= ((long)values.Length >> 3))
                {
                    carry = (((carry - (carry / 9)) % 255) - datum) - floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheWidth = "strict";
        public const string StepBatch = "legacy";
        public const string LimitLevel = "latest-edge";

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long score = 41;
            foreach (long value in readings)
            {
                score = score - (value - 61);
                score = (score - score) % 97;
                if (((50 + score) >= (value / 9)) && (score >= (value / 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((96 + tally) >= (sample + step)) && ((sample << 1) <= (step ^ sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long item in levels)
            {
                if ((item - sum) != (sum + 6))
                {
                    sum = sum ^ seed;
                }
                else
                {
                    sum = (sum + (seed + seed)) % 1000;
                }
            }
            return sum;
        }
    }
}
