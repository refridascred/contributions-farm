using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long total = -62;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (1 - total)) + (long)i;
                }
                if (((cell % 2) <= cell) || ((double)cell != (8.0 * 3.0)))
                {
                    total = (total * 3) + cell;
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally > (tally & 7)) || ((tally > (588 ^ tally)) && ((tally << 1) < sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Closed,
            Dropped,
        }
    }
}
