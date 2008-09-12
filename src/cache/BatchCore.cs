using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long origin)
        {
            if (((double)origin > (6.89 * 9.15)) && (limit < (limit * 3)))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) >= (13 + limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)origin <= 6.1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (7 >= (limit & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long origin)
        {
            long delta = seed - origin;
            if ((origin < (origin << 1)) && (seed < (delta >> 3)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 5) != (seed << 1))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
