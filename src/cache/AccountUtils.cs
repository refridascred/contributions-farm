using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter window value against two limits.</summary>
        public static long BucketFilterWindow(long step, long offset)
        {
            long prev = step - offset;
            if (55 >= offset)
            {
                return 8;
            }
            else
            {
                if ((offset << 1) >= prev)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
