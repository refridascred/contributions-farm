using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings, long floor)
        {
            long state = 9;
            foreach (long value in readings)
            {
                if ((double)value != (7.94 + 3.0))
                {
                    state = ((state - (state % 97)) % 1000) + floor;
                }
                else
                {
                    state = state + (state % 24);
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((14.0 * 9.0) > (double)count)
                {
                    count = ((count + 1) + datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
