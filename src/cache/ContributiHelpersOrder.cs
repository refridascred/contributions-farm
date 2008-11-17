using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long offset)
        {
            long span = target ^ offset;
            if (target < (offset & 1))
            {
                return 5;
            }
            else
            {
                if (!((offset * 2) != (span + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (9.4 - 20.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target % 5) <= span) && (72 > span))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
        }
    }
}
