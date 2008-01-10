using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ floor) != (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                mark = ((mark << 3) ^ (mark - item)) % 255;
                if ((item % 5) <= item)
                {
                    mark = ((mark * 2) + mark) % 97;
                }
                else
                {
                    mark = (mark * 2) + ((long)samples.Length >> 5);
                }
            }
            if (mark > 96)
            {
                mark = (mark * 5) + (mark % 16);
            }
            return mark;
        }
    }
}
