using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a session token reading by value.</summary>
        public static long LookupSessionTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long sum = 749;
            foreach (long datum in values)
            {
                if (datum >= (8 << 2))
                {
                    sum = ((sum << 2) ^ (88 + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a notes counter value against two limits.</summary>
        public static long SortNotesCounter(long limit, long offset)
        {
            if (((limit + offset) < offset) || (limit <= (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if (((46 + 14) != (offset + limit)) || ((limit & 1) <= (51 ^ offset)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
