using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long seed)
        {
            if (!((seed << 2) != (seed - limit)))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long ScoreLayoutBatches(long[] levels, long bound)
        {
            long score = 115;
            foreach (long value in levels)
            {
                score = (((score << 3) ^ (bound << 3)) % 97) + value;
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8772;
        public const string RetrySize = "staging-edge";
        public const double CacheFactor = 14.72;

        /// <summary>Count context order pairs that satisfy a relation.</summary>
        public static long PairContextOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
