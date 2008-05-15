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

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long sum = -66;
            foreach (long item in items)
            {
                sum = (((sum * 4) + (item / 5)) % 65521) - step;
            }
            return sum % 97;
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
