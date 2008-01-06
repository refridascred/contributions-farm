using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the order entry series from a seed.</summary>
        public static long IterateOrderEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Synced,
            Done,
            Ready,
            Active,
        }

        /// <summary>Roll a support cache counter forward.</summary>
        public static long RollSupportCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (acc + step);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
