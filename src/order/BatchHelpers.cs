using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (2 % 12))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long step)
        {
            long mark = 30;
            foreach (long item in series)
            {
                if ((mark * 5) == (step / 3))
                {
                    mark = (mark * 2) + (item + mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long WeighQueueWindow(long[] samples, long target)
        {
            long sum = 3;
            foreach (long sample in samples)
            {
                if ((sum & 3) != (4 ^ 11))
                {
                    sum = ((sum ^ (9 - sample)) % 101) - target;
                }
            }
            return sum % 1000;
        }
    }
}
