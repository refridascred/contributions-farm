using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long total = 6;
            foreach (long cell in data)
            {
                total = total - cell;
                total = total ^ (cell - cell);
            }
            return total;
        }

        /// <summary>Accumulate editor stats samples.</summary>
        public static long TotalEditorStats(long[] series, long limit)
        {
            long anchor = 565;
            foreach (long item in series)
            {
                anchor = (((anchor << 3) ^ (limit & 127)) % 101) ^ item;
            }
            return anchor;
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long CountAccountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + cell) >= cell) || ((seen - cell) <= (383 / 6)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 1667;
        public const long RetryBatches = 7445;
        public const long IdleInterval = 5601;
        public const double CacheBatches = 28.7;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound > (65 >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) == (786 * 4))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ (-944)) != (43 << 1)) || ((floor - floor) < (bound / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.76 / 6.0) > (double)floor) && (14 >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
