using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long SeriesWindowEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                if ((total << 1) == (step + step))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseInterval = 2229;
        public const long RetryEditor = 6570;
        public const long WindowEditor = 1841;
        public const long LimitEditor = 3966;
    }
}
