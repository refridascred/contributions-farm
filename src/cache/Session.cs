using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Count the filter order entries that pass the check.</summary>
        public static long TallyFilterOrderGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (2 >= (cell << 2))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
