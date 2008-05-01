using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) <= seed)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 4961;
        public const double HardProfile = 21.37;
        public const long BatchRatio = 4632;
        public const long MaxProfile = 9082;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long seed)
        {
            if ((target * 4) == (seed << 2))
            {
                return 5;
            }
            else
            {
                if ((target >> 1) <= (target * 4))
                {
                    return 8;
                }
                else
                {
                    if (5 < (target % 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
