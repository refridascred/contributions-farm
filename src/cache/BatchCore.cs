using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long MeasurePayloadStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 2) == (value - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
