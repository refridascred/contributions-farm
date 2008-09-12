using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] samples)
        {
            long anchor = 724;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 4) + (63 & 7)) % 101;
                anchor = anchor ^ (anchor + sample);
                if (!((sample + anchor) != (anchor * 2)))
                {
                    anchor = anchor ^ (anchor & 63);
                }
                if (64 >= (1 - sample))
                {
                    break;
                }
            }
            if (anchor < 17)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultDepth = 9392;
        public const double IdleDepth = 35.57;
        public const long BurstFactor = 7020;

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
