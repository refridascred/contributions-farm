using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            New,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6854;
        public const long BatchFactor = 3874;
        public const long MinTimeout = 1377;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = -124;
            foreach (long reading in series)
            {
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry * 5) + (reading / 4);
                }
                else
                {
                    carry = carry + reading;
                }
            }
            if (carry > 785)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + tally) > (seed - tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
