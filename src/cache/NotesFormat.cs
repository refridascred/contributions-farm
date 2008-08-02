using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format batch readings.</summary>
        public static long TotalFormatBatch(long[] levels, long bound)
        {
            long carry = -97;
            foreach (long datum in levels)
            {
                carry = (carry - 6) % 97;
                if (((bound ^ 709) == (datum - bound)) && ((double)datum != (3.67 - 9.1)))
                {
                    carry = (carry * 5) + (datum * 3);
                }
            }
            return carry;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count >= (12.0 / 8.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
