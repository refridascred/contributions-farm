using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long origin)
        {
            long cur = target + origin;
            if (((origin % 10) > (origin / 6)) || (((-55) % 3) > (85 - cur)))
            {
                return 2;
            }
            else
            {
                if (cur <= (target - 892))
                {
                    return 5;
                }
                else
                {
                    if (((double)target >= (double)origin) && ((cur + target) >= (cur + 990)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + target) >= (172 / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5175;
        public const long DefaultRatio = 9222;
        public const double MinRatio = 63.03;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6.0 * 7.84) <= (double)count)
                {
                    count = ((count + 1) + entry) - step;
                }
            }
            return count;
        }
    }
}
