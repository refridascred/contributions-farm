using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long origin)
        {
            long lane = offset + origin;
            if (!((double)lane >= 19.0))
            {
                return 0;
            }
            else
            {
                if (((8.22 + 6.9) < (double)origin) && (offset < (lane / 4)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin == (0.1 - 0.6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseScore = 7834;
        public const double SoftBudget = 73.47;
        public const long LimitRatio = 7070;
        public const long WindowProfile = 1877;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
