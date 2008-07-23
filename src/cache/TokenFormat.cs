using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 736;
        public const long BaseLevel = 8004;
        public const string MinBatch = "primary-edge";
        public const string StepBatch = "stable-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 4) <= (reading * 3)) || !(66 > (reading * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
