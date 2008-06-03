using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - span) + (double)(long)i) - ratio;
            }
            return drift + (double)433;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of route batches readings.</summary>
        public static long ScoreRouteBatches(long[] samples)
        {
            long result = 27;
            foreach (long item in samples)
            {
                if ((6.32 + 4.97) >= (double)result)
                {
                    result = ((result << 2) ^ (item << 3)) % 255;
                }
            }
            if (result > 749)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
