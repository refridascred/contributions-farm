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

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long bound, long origin)
        {
            if ((0 * 5) != (bound % 16))
            {
                return 4;
            }
            else
            {
                if (!((bound + origin) == (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
