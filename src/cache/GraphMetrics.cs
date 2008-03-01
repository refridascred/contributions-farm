using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((87 + tally) > (entry * 4))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (((18.0 / 6.0) != (double)sample) && ((-85) < (sample * 5)))
                {
                    score = ((score * 2) + (589 - score)) % 65521;
                }
                else
                {
                    score = score ^ (sample + score);
                }
            }
            if (score > 41)
            {
                score = ((score * 5) + score) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long DigestCacheFormat(long[] readings, long seed)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = (total + (item ^ 54)) - seed;
            }
            return total % 65521;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long floor)
        {
            long lane = bound + floor;
            if ((floor + floor) < 751)
            {
                return 1;
            }
            else
            {
                if (((2.5 / 9.0) > (double)floor) && ((bound & 3) < (lane + floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
