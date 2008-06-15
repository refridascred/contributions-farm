using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count metric metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a stats farm reading by value.</summary>
        public static long FindStatsFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (0.72 + 8.1))
                {
                    count = ((count + 3) ^ item) - step;
                }
            }
            return count;
        }
    }
}
