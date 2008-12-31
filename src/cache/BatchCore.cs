using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Ready,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long limit)
        {
            if ((limit + seed) >= (limit & 63))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) <= 314)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long offset)
        {
            long step = limit - offset;
            if (offset < (offset * 2))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)4)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9896;
        public const long LimitLevel = 3238;
        public const string StepTools = "staging";
        public const long SoftTools = 2890;
    }
}
