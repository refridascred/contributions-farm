using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long LookupRecordBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster window pairs that satisfy a relation.</summary>
        public static long CompareClusterWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long anchor = -6;
            foreach (long datum in data)
            {
                if (datum <= (anchor / 4))
                {
                    anchor = (anchor + (datum / 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
