using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long BucketEntryTools(long bound, long limit)
        {
            if ((double)bound > (8.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((limit % 24) != (limit % 10))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "alpha-edge";
        public const double HardSupport = 41.19;
        public const long IdleScore = 1804;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ step) >= 5)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
