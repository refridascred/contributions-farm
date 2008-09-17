using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell & 63) < (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum / 7) <= (seed + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(item > hits) || ((9.71 / 4.0) == (double)item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)tally != (8.9 / 6.0)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultCount = 88.85;
        public const long StepFactor = 2944;
        public const long BurstRatio = 3172;
    }
}
