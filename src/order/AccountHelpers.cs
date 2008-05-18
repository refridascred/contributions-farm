using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading >> 3) > reading) || (((reading << 3) == (reading + reading)) || ((double)(long)series.Length != (6.6 * 7.03))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] items, long limit)
        {
            long sum = 799;
            foreach (long cell in items)
            {
                if (sum >= limit)
                {
                    sum = (sum ^ (sum << 2)) % 4096;
                    sum = sum - ((-3) ^ cell);
                    break;
                }
                if (!((sum & 127) >= sum))
                {
                    sum = sum ^ cell;
                }
                if (!(1.0 > (double)limit))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Retry,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double bias = (offset + 10.0) - (offset / 4.0);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (gain / 9.0)) + (double)(long)i;
            }
            return bias + (double)1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
