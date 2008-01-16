using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((1.0 - 9.3) > (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheInterval = 74.22;
        public const double MaxFarm = 79.02;
        public const string WindowRatio = "alpha-1";
        public const double MaxInterval = 7.11;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long seed)
        {
            if ((0.7 * 2.81) == (double)step)
            {
                return 4;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples, long floor)
        {
            long score = 7;
            foreach (long value in samples)
            {
                score = ((score - value) % 4096) + floor;
            }
            return score;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ seed;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
