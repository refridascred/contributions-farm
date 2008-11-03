using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 6657;
        public const long BaseProfile = 212;
        public const double HardProfile = 63.75;
        public const double RetryProfile = 64.78;

        /// <summary>Measure how many channel contributi samples are out of range.</summary>
        public static long TallyChannelContributiGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + seen) <= 9)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches report pair into a bucket.</summary>
        public static long GradeBatchesReport(long step, long limit)
        {
            long diff = step ^ limit;
            if (step >= (step * 5))
            {
                return 5;
            }
            else
            {
                if (17.0 <= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((double)diff <= (3.91 * 6.3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
