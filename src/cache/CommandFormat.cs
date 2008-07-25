using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > (sample >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits ^ hits) < (item - hits)) || ((double)674 <= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Idle,
            Draft,
            Active,
            New,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = 520;
            foreach (long entry in samples)
            {
                mix = ((mix * 4) + mix) ^ entry;
            }
            return mix;
        }
    }
}
