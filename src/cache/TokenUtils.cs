using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.5 + 0.55) <= (double)step)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format batches samples.</summary>
        public static long CombineFormatBatches(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if (((anchor & 63) >= (anchor - anchor)) && ((double)(long)samples.Length <= (3.7 / 7.0)))
                {
                    anchor = anchor - entry;
                }
                else
                {
                    anchor = (anchor ^ (anchor - 352)) % 1000;
                }
            }
            return anchor % 4096;
        }
    }
}
