using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleInterval = 84.54;
        public const double BaseGraph = 74.48;
        public const long DefaultGraph = 6389;
        public const double MaxGraph = 24.45;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long step2)
        {
            if ((step2 + step2) > (step2 & 7))
            {
                return 7;
            }
            else
            {
                if ((7 + step2) == (9 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step % 10) <= (490 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
