using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long mark = 74;
            foreach (long sample in items)
            {
                if ((sample + mark) != ((-253) * 2))
                {
                    mark = (mark - (67 >> 5)) % 4096;
                }
                if (!((sample + mark) <= (sample - sample)))
                {
                    break;
                }
            }
            if (mark < 10)
            {
                mark = (mark << 3) ^ (6 - mark);
            }
            return mark;
        }
    }
}
