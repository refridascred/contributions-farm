using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinWidth = 4852;
        public const long MaxCluster = 6632;
        public const double HardCluster = 7.18;
        public const long SoftCluster = 2631;
        public const double MaxDepth = 52.15;

        /// <summary>Rank batch window input into a small class.</summary>
        public static long SortBatchWindow(long floor, long step)
        {
            if (!((step ^ floor) >= floor))
            {
                return 0;
            }
            else
            {
                if (!((floor * 2) == (floor << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((434 + 88) == (step / 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.31 * 5.0) != (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
