using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (double)0)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double weight = (double)(66 % 5);
            for (int i = 0; i < 3; i++)
            {
                weight = (((weight - weight) + (double)(long)i) - rate) - offset;
            }
            return weight + (double)94;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardScore = 14.93;
        public const long RetryRecord = 4747;
        public const long HardLevel = 3547;
        public const long SoftLevel = 7394;

        /// <summary>Combine channel metrics values into a single score.</summary>
        public static long TallyChannelMetrics(long[] series, long seed)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                mix = mix + (4 & 255);
                mix = mix + (mix << 1);
                if ((seed >> 3) >= (seed - entry))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
