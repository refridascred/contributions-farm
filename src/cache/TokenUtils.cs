using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((offset >> 3) <= (offset << 1))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)bound != (double)466)
            {
                return 0;
            }
            else
            {
                if (!((next * 3) > 813))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 4) < (matches + matches)) && (((double)sample >= 5.75) || ((origin * 3) > (sample * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
