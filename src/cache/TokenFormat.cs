using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next report entry value.</summary>
        public static double ScaleReportEntry(double bias, double bias2)
        {
            double scale = bias - (bias2 - bias2);
            return scale + scale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell - count) < (cell - 48)) || (cell > 76))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a queue window sample.</summary>
        public static long SeekQueueWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
