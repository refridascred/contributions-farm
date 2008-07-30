using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit profile batches readings against a rule.</summary>
        public static long TallyProfileBatchesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally + tally) >= (tally - (long)levels.Length)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "local-1";
        public const double LimitPayload = 20.52;
        public const long WindowSize = 1520;
        public const long WindowSpan = 7555;

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxWidth = 55.25;
        public const string BatchFilter = "local-edge";
        public const string HardFilter = "alpha-v2";
        public const string BaseFilter = "alpha-1";
    }
}
