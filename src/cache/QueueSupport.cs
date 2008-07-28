using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long limit)
        {
            if ((double)origin > (4.92 * 4.2))
            {
                return 2;
            }
            else
            {
                if (((origin ^ origin) <= 19) && ((double)limit > 7.8))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
