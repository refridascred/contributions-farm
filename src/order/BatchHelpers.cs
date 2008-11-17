using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long offset)
        {
            long offset2 = step + offset;
            if ((offset >> 4) < step)
            {
                return 0;
            }
            else
            {
                if ((step + step) >= (step + offset2))
                {
                    return 6;
                }
                else
                {
                    if ((5.6 - 4.43) == (double)offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - step) >= (offset * 4))
                        {
                            return 2;
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
