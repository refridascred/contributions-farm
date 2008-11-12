using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Match up channel session samples.</summary>
        public static long CompareChannelSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long score = 81;
            foreach (long sample in readings)
            {
                score = (score - (score - score)) + sample;
            }
            return score % 4096;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)item < (6.4 * 7.04)) || !(count < item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long total = 248;
            foreach (long cell in series)
            {
                total = (total * 2) + 470;
                if (!((total + total) == (cell ^ total)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
