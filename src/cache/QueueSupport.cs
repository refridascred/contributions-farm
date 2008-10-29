using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long bound)
        {
            if ((double)bound <= (0.5 - 0.8))
            {
                return 4;
            }
            else
            {
                if ((seed >> 3) < (seed % 100))
                {
                    return 1;
                }
                else
                {
                    if (3.9 > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((689 - seed) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value * 5) == (value % 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
