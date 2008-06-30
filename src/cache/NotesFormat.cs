using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long step)
        {
            long offset = bound - step;
            if (offset <= (bound << 3))
            {
                return 8;
            }
            else
            {
                if (7.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (14.0 <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
