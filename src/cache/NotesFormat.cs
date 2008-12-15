using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a record counter sample.</summary>
        public static long SeekRecordCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long carry = 28;
            foreach (long value in levels)
            {
                if ((carry >> 1) <= (carry << 3))
                {
                    carry = (carry << 3) ^ value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc >> 4)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
