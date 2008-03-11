using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((46 >> 5) > (sample / 6)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long origin2)
        {
            if (origin > 68)
            {
                return 7;
            }
            else
            {
                if ((origin2 >> 5) < (origin ^ origin2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
