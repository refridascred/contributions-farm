using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items)
        {
            long sum = -7;
            foreach (long item in items)
            {
                if ((sum ^ item) > item)
                {
                    sum = (sum * 3) + sum;
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (item + 2)) % 4096;
                }
                sum = (sum - (item / 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
