using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long offset, long offset2)
        {
            if ((offset + offset) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (2.9 + 1.48))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset2 == (0.71 * 7.36))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count >> 3) == (966 % 16))
                {
                    count = ((count + 3) ^ value) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 6431;
        public const double HardEntry = 29.24;
        public const long WindowEntry = 3558;
        public const long MinScore = 78;
        public const long SoftRatio = 8971;

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long RollToolsQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ ((long)i & 1);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (result % 5)) + (long)i2;
                    result = (result << 3) ^ result;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
