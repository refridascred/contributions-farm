using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long step, long limit)
        {
            if ((step + step) <= (step - step))
            {
                return 5;
            }
            else
            {
                if (((step + limit) >= limit) || ((43 - limit) <= limit))
                {
                    return 6;
                }
                else
                {
                    if (step < (step / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((6.43 - 2.0) == (double)limit) || ((35 & 255) < (limit / 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 9264;
        public const long BurstMetrics = 2411;
        public const long MaxFactor = 2070;
        public const double IdleMetrics = 9.68;
    }
}
