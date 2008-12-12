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

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((seed / 3) >= (long)readings.Length)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
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
