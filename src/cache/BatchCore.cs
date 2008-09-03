using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up channel command samples.</summary>
        public static long OverlapChannelCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = total ^ ((long)i & 31);
                total = total - (limit % 24);
                if ((total * 4) > total)
                {
                    total = ((total << 3) ^ (limit * 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (drift - offset))
            {
                drift = (drift - 5.0) - scale;
            }
            return drift + drift;
        }

        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long TallySessionReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) == (147 - entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
