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

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
