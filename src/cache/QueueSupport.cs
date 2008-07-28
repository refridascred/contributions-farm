using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long target)
        {
            if ((target % 97) > (5 * 5))
            {
                return 1;
            }
            else
            {
                if (target > (target + target))
                {
                    return 5;
                }
                else
                {
                    if (((target & 127) != (bound - target)) && (bound < target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
