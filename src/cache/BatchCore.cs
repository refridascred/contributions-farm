using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double rate2 = (double)((-346) << 3);
            if (rate2 >= (rate2 - floor))
            {
                rate2 = (rate2 - (double)(-851)) + rate;
            }
            return rate2 - floor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen * 3) <= (item * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(step < (302 + hits)) || ((47 - hits) < value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
