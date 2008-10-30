using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((2.11 / 5.0) <= (double)count)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
