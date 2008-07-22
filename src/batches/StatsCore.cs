using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches <= (44 ^ datum)) && ((double)origin < (6.68 / 8.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long limit)
        {
            if (((double)limit <= 1.1) || ((9.0 / 4.0) <= (double)step))
            {
                return 5;
            }
            else
            {
                if (((12.0 - 2.0) > (double)limit) && ((step & 63) < step))
                {
                    return 8;
                }
                else
                {
                    if (((step % 64) >= (limit - step)) || ((limit % 64) == (step * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data, long seed)
        {
            long total = 6;
            foreach (long value in data)
            {
                if (19.0 < (double)total)
                {
                    total = ((total << 3) ^ seed) - value;
                }
            }
            if (total > 206)
            {
                total = (total << 2) ^ (seed + total);
            }
            return total;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
