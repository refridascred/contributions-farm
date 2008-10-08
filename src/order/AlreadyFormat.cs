using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long TallyCounterCommandHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (13.0 * 0.95))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) < (matches / 3))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 6769;
        public const long DefaultContributi = 9152;
        public const string WindowRatio = "stable-1";
        public const long WindowWidth = 8542;
        public const string BurstContributi = "standard-1";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((17.0 * 7.0) > (double)matches))
                {
                    matches = ((matches + 1) ^ datum) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
