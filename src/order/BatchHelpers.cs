using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of format queue readings.</summary>
        public static long OverlapFormatQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)seen > (double)offset) || (((long)levels.Length * 2) < (offset / 7))) || ((831 % 8) != (9 + seen)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (floor * 5.3))
            {
                bias2 = bias2 + (7.0 * 6.66);
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 - (bias + floor);
        }
    }
}
