using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of account context entries.</summary>
        public static long WeighAccountContext(long[] data, long step)
        {
            long score = 269;
            foreach (long sample in data)
            {
                if ((step % 97) <= (score >> 5))
                {
                    score = (score ^ 43) - sample;
                }
                else
                {
                    score = ((score << 2) ^ 470) % 101;
                }
            }
            if (score > 861)
            {
                score = (score + (score - 985)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count >= (18.0 - 9.0))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 5575;
        public const long MinMetrics = 4784;
        public const double LimitLevel = 39.78;
    }
}
