using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Active,
            Paused,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long step)
        {
            long lane = offset ^ step;
            if ((lane * 2) == (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((20.0 * 5.47) <= (2.4 - 2.9))
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (step + step)) || ((-43) < lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane << 1) < (lane + 62))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (total < ((long)i >> 1))
                {
                    total = ((total * 3) + ((long)i ^ 6)) % 1000;
                    total = (total + (total << 3)) % 101;
                }
                total = (total + (-5)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
