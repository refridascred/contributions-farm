using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route window entries that pass the check.</summary>
        public static long TallyRouteWindowHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((19.0 - 2.3) < (double)offset)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ (target << 2)) % 4096;
                anchor = (anchor ^ (target + target)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor + target) + (long)i2;
                    anchor = ((anchor << 3) ^ (target + target)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
