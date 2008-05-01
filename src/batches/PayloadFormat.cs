using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit farm window readings against a rule.</summary>
        public static long TallyFarmWindowOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length + 600) != (18 << 2))
                {
                    matches = ((matches + 3) ^ sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinInterval = 7132;
        public const long HardSpan = 1919;
        public const long CacheInterval = 4266;
        public const long CacheTimeout = 7917;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            long next = limit - bound;
            if (((-2) << 1) == (next + bound))
            {
                return 5;
            }
            else
            {
                if (bound <= (next % 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound / 5) > (next ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a graph context reading by value.</summary>
        public static long FindGraphContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
