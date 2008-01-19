using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                long edge = (-137) + (mark + mark);
                if ((edge < seed) || ((seed ^ (long)i) <= (188 * 5)))
                {
                    edge = (edge * 2) + mark;
                    edge = edge - (seed + edge);
                    break;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
