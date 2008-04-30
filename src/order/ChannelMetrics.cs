using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item < (hits - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long SeriesNotesStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (seed / 6)) % 4096;
                state = state - ((long)i ^ state);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a entry buffer reading.</summary>
        public static double ScaleEntryBuffer(double weight, double bias)
        {
            double scale = (double)(83 % 10);
            if (scale < weight)
            {
                scale = (scale + weight) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (double)(-9);
        }
    }
}
