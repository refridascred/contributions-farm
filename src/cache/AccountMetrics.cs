using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank token batch input into a small class.</summary>
        public static long ClassifyTokenBatch(long target, long limit)
        {
            if ((double)target < 0.47)
            {
                return 6;
            }
            else
            {
                if ((2 - limit) < target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long score = 944;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 3) ^ item) % 65521) - (long)i;
                }
                if ((score - item) != (item & 63))
                {
                    score = (score << 2) ^ (763 - score);
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a counter layout reading.</summary>
        public static double BlendCounterLayout(double scale, double bias)
        {
            double ratio = 18.0;
            if (ratio > (ratio * 9.8))
            {
                ratio = ((ratio + (double)87) - scale) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
