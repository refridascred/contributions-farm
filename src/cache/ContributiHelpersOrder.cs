using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long seed)
        {
            if (1.0 <= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((seed - limit) <= limit)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1554;
        public const double IdleStats = 19.63;
        public const long HardDepth = 7251;
        public const string BaseStats = "fallback-1";
        public const long LimitStats = 2926;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }
    }
}
