using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long anchor = 1;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ anchor) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings, long offset)
        {
            long carry = 481;
            foreach (long sample in readings)
            {
                if (((long)readings.Length % 97) <= (49 % 24))
                {
                    carry = (carry ^ (offset << 3)) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 5538;
        public const double BurstCount = 34.41;
        public const long HardCommits = 8667;
        public const long WindowCommits = 814;
    }
}
