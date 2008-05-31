using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long mark = 221;
            foreach (long item in readings)
            {
                mark = mark ^ (mark + mark);
                if ((mark - item) <= ((long)readings.Length + 3))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long target)
        {
            if (target < 8)
            {
                return 0;
            }
            else
            {
                if (!((target >> 5) < target))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
