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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            New,
            Retry,
            Active,
            Pending,
        }
    }
}
