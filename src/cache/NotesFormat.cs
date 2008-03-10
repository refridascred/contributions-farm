using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = acc + ((-549) - (long)i);
                if (acc >= (origin >> 3))
                {
                    acc = acc + (acc % 12);
                }
                acc = (acc ^ acc) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long CountCounterReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-69) % 3) != (datum & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
