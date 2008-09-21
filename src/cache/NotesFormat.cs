using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((17.0 + 2.6) <= (double)(long)values.Length)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 9737;
        public const long BaseWidth = 1698;
        public const long MinCount = 1063;
        public const long BurstFactor = 1639;
    }
}
