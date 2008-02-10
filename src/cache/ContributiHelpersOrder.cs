using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Done,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            if ((double)offset < 5.41)
            {
                return 5;
            }
            else
            {
                if (offset > seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) >= (seed - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
