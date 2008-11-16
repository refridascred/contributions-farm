using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            New,
            Synced,
            Locked,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc + seed) - (long)i2;
                    acc = (acc << 2) ^ (seed + seed);
                }
                acc = (acc + (seed % 7)) % 65521;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell ^ hits) > (53 + seed)) || ((double)cell >= (9.5 / 5.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
