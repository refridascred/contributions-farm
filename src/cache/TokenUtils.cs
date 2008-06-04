using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5083;
        public const long SoftQueue = 3892;
        public const long RetryCount = 1555;
        public const string StepQueue = "open-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count > (sample % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long acc = 535;
            foreach (long item in values)
            {
                if ((item + item) < (acc * 2))
                {
                    acc = acc - (item % 64);
                }
                if (((item - acc) >= item) || (acc <= (acc * 4)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
