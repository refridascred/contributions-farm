using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry farm readings against a rule.</summary>
        public static long MeasureEntryFarmOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) == (56 ^ reading))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardFactor = "standard-1";
        public const long LimitGraph = 4227;
        public const string MinRatio = "stable";
        public const long BaseScore = 4250;
        public const string LimitCount = "cached-edge";

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
