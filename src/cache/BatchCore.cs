using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if (!((double)limit >= (12.0 * 16.0)))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 2.0) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two commits context measurements.</summary>
        public static double ProjectCommitsContext(double rate, double span)
        {
            double rate2 = (double)(5 / 8);
            if (rate2 < (rate / 5.0))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 - rate)) - (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
