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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2407;
        public const double RetryStats = 19.5;
        public const double MinStats = 50.57;
        public const long DefaultStats = 8491;
        public const double BatchStats = 13.94;

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
