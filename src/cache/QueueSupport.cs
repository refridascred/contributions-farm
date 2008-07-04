using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long CombineContributiCluster(long[] items)
        {
            long mark = 32;
            foreach (long datum in items)
            {
                mark = (mark + 42) + datum;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                long bound2 = mark * 2;
                if (!((mark % 12) >= (mark / 8)))
                {
                    mark = (mark - (bound2 + bound)) % 4096;
                    mark = ((mark << 2) ^ (long)values.Length) % 1000;
                }
                if (((double)mark >= (16.0 + 4.6)) && ((double)entry > (9.33 / 2.0)))
                {
                    mark = ((mark << 3) ^ (bound / 4)) % 101;
                }
                if (!((long)values.Length > entry))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleSpan = "standard-v2";
        public const long RetryChannel = 8835;
        public const long HardSpan = 196;
        public const long WindowBudget = 6177;
    }
}
