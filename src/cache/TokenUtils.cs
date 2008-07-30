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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2514;
        public const long WindowCluster = 4168;
        public const long SoftCluster = 8294;
        public const long LimitInterval = 9667;

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxWidth = 55.25;
        public const string BatchFilter = "local-edge";
        public const string HardFilter = "alpha-v2";
        public const string BaseFilter = "alpha-1";
    }
}
