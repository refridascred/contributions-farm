using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stats contributi readings.</summary>
        public static long TallyStatsContributi(long[] levels)
        {
            long total = 361;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item - item)) % 255;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinCount = 59.69;
        public const string BurstLevel = "standard";
        public const long SoftTools = 6531;
        public const long BurstTools = 9237;
        public const long DefaultLevel = 496;

        /// <summary>Classify a already metrics pair into a bucket.</summary>
        public static long BucketAlreadyMetrics(long origin, long floor)
        {
            if (origin < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((origin - floor) < floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor * 4) < 111)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
