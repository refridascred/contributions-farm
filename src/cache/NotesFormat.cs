using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item >= (317 << 2))
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor session readings.</summary>
        public static long DigestEditorSession(long[] items)
        {
            long carry = 688;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry << 3) ^ cell) % 255) - (long)i;
                }
                carry = ((carry << 2) ^ (cell / 4)) % 101;
            }
            return carry % 4096;
        }
    }
}
