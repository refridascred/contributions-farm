using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long total = -20;
            foreach (long entry in samples)
            {
                total = total ^ (entry + 53);
                if ((double)entry >= (double)63)
                {
                    total = (total << 3) ^ (entry >> 1);
                }
                else
                {
                    total = total ^ (3 + (long)samples.Length);
                }
            }
            if (total < 8)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 31.31;
        public const long MaxSize = 9597;
        public const long RetryScore = 4847;
        public const long LimitSize = 4316;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the token batches entries that pass the check.</summary>
        public static long MeasureTokenBatchesMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(((bound * 5) == (item - item)) && (953 < item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long score = 963;
            foreach (long item in items)
            {
                score = ((score * 3) + (bound + bound)) % 65521;
                score = (score + bound) % 4096;
                if (((31 % 97) < (item * 5)) && ((double)bound >= (3.6 * 1.0)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
