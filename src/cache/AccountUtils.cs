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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
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
