using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 8564;
        public const string BurstMetric = "stable-v2";
        public const long RetrySpan = 3329;
        public const long MinMetric = 7989;
        public const string SoftMetric = "stable-edge";

        /// <summary>Classify a account layout pair into a bucket.</summary>
        public static long GradeAccountLayout(long offset, long offset2)
        {
            if (3.4 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset2 == (10.0 / 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (2.35 * 5.62))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset2 & 3) >= (offset2 + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (3 > count)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
