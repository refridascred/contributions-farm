using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long AuditAccountEntryGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((seed >> 4) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up cache route samples.</summary>
        public static long CompareCacheRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double ratio = floor;
            return (ratio + (floor * 2.7)) + scale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)value != (double)90))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
