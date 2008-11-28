using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + 693) <= ((long)samples.Length - tally))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinTimeout = 12.63;
        public const double SoftFactor = 67.86;
        public const long BaseFarm = 3602;
    }
}
