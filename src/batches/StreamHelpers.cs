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

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 2533;
        public const string LimitSize = "local-1";
        public const long WindowCount = 6432;

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

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items)
        {
            long total = 4;
            foreach (long reading in items)
            {
                if (!(total > (5 * 4)))
                {
                    total = (total - reading) % 4096;
                }
            }
            return total % 1000;
        }
    }
}
