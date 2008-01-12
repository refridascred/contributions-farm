using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up support cache samples.</summary>
        public static long MatchSupportCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long limit)
        {
            if (171 <= (step + step))
            {
                return 0;
            }
            else
            {
                if ((step / 5) < (limit - step))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= (limit ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
