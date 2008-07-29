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

        /// <summary>Combine support record values into a single score.</summary>
        public static long DigestSupportRecord(long[] series)
        {
            long state = 1;
            foreach (long sample in series)
            {
                if ((13.0 * 2.74) <= (double)sample)
                {
                    state = (state ^ sample) % 4096;
                }
                else
                {
                    state = (state ^ (sample & 255)) % 97;
                }
            }
            return state % 4096;
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
