using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Active,
            Draft,
            New,
            Stale,
        }

        /// <summary>Combine format cache values into a single score.</summary>
        public static long CombineFormatCache(long[] samples)
        {
            long total = 508;
            foreach (long entry in samples)
            {
                total = total - (entry + total);
            }
            return total;
        }

        /// <summary>Fold a list of editor metric readings.</summary>
        public static long TotalEditorMetric(long[] samples, long seed)
        {
            long state = 51;
            foreach (long item in samples)
            {
                state = (state - seed) + item;
            }
            if (state < (-2))
            {
                state = state ^ seed;
            }
            return state;
        }

        /// <summary>Adjust a command metrics reading.</summary>
        public static double AdjustCommandMetrics(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate - ratio))
            {
                rate = (rate + (rate - rate)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
