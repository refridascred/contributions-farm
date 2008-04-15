using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (double)floor)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 540;
        public const long BatchDepth = 8675;
        public const long DefaultContributi = 3171;
        public const long MaxContributi = 9211;
        public const long HardContributi = 3019;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Paused,
            Retry,
        }
    }
}
