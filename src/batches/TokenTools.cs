using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 5480;
        public const double RetryCount = 6.43;
        public const long RetryOrder = 441;
        public const long MaxOrder = 8178;

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long ClassifyQueueEntry(long seed, long floor)
        {
            if (((seed + floor) > seed) && ((floor + seed) > (seed + floor)))
            {
                return 2;
            }
            else
            {
                if (!((12.0 + 5.0) >= (double)seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor / 9) < 64)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor) < seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
