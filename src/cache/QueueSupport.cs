using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long origin)
        {
            if (origin < (51 >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (6.15 + 5.24))
                {
                    return 4;
                }
                else
                {
                    if (((9.11 + 12.0) >= (double)origin) || ((floor + origin) >= (origin / 8)))
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

        /// <summary>Locate a profile metric reading by value.</summary>
        public static long FindProfileMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 22.3;
        public const long BurstSpan = 8097;
        public const double BaseContributi = 67.2;
        public const string SoftContributi = "strict";
    }
}
