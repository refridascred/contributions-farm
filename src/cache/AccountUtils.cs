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

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2835;
        public const long BaseDepth = 2874;
        public const long CacheCount = 7068;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long limit)
        {
            long sum = 63;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum << 3) ^ (datum + datum)) + (long)i;
                    sum = sum + (4 << 2);
                }
                sum = (sum + datum) % 65521;
                if ((3.0 - 2.0) != (double)sum)
                {
                    sum = sum - (datum + limit);
                }
                else
                {
                    sum = (sum - 517) % 65521;
                }
            }
            return sum;
        }
    }
}
