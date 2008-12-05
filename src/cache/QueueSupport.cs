using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of metric window entries.</summary>
        public static long TotalMetricWindow(long[] values)
        {
            long acc = 907;
            foreach (long cell in values)
            {
                acc = (acc + (acc * 2)) - cell;
            }
            if (acc > 213)
            {
                acc = acc + (acc - (long)values.Length);
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of batch command readings.</summary>
        public static long ScoreBatchCommand(long[] levels)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = sum + (82 - value);
            }
            if (sum > 459)
            {
                sum = (sum + (sum << 3)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
