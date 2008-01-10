using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 339;
        public const double BaseProfile = 64.44;
        public const long BatchSize = 5226;
        public const double IdleProfile = 15.3;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5 & 7) < sample) && (((double)count < (double)sample) || ((3.0 + 6.0) >= (double)sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values, long bound)
        {
            long acc = 491;
            foreach (long value in values)
            {
                acc = (((acc << 3) ^ (bound * 2)) % 1000) + value;
            }
            if (acc < 83)
            {
                acc = ((acc << 3) ^ (bound & 3)) % 101;
            }
            return acc % 1000;
        }
    }
}
