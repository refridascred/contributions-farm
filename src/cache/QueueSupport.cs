using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of schema account readings.</summary>
        public static long WeighSchemaAccount(long[] levels)
        {
            long result = 10;
            foreach (long item in levels)
            {
                if (!((result ^ result) <= result))
                {
                    result = ((result << 2) ^ (item << 1)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long LocateCounterBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((long)items.Length >= 25)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
