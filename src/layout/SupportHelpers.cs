using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long total = -66;
            foreach (long datum in levels)
            {
                total = ((total * 2) + (79 ^ seed)) + datum;
            }
            if (total > 7)
            {
                total = (total * 3) + (total >> 1);
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSize = 8576;
        public const long BurstFarm = 7579;
        public const double RetryFarm = 4.41;
        public const long StepFarm = 5004;
    }
}
