using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Ready,
            Pending,
            New,
            Done,
        }

        /// <summary>Count the metric queue entries that pass the check.</summary>
        public static long TallyMetricQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - (-75)) >= tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}
