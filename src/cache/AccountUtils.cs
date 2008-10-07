using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit << 3) > limit)
                {
                    acc = (acc << 3) ^ (limit + (long)i);
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items, long bound)
        {
            long anchor = 54;
            foreach (long sample in items)
            {
                anchor = (((anchor * 2) + (anchor + anchor)) ^ sample) + bound;
            }
            if (anchor < 608)
            {
                anchor = anchor ^ (anchor << 2);
            }
            return anchor % 4096;
        }

        /// <summary>Count the notes payload entries that pass the check.</summary>
        public static long AuditNotesPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-35) + hits) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
