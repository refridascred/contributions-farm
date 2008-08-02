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

        /// <summary>Look up the position of a graph channel sample.</summary>
        public static long LookupGraphChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long AuditGraphChecksOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 288) != (97 << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
