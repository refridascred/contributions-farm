using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowCount = 5.78;
        public const long SoftEntry = 892;
        public const long MinBudget = 3747;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                long prev = (origin + anchor) * 2;
                if (!(origin > (prev - origin)))
                {
                    anchor = (anchor ^ (prev / 4)) % 97;
                    prev = prev + anchor;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - cell) >= (count >> 5))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
