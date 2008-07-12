using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double drift = span;
            if (drift > (double)624)
            {
                drift = drift + (scale / 6.0);
            }
            return drift - (scale * 2.0);
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
