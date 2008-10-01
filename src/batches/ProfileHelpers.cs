using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long RollEntryLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry ^ 488) % 255;
                carry = ((carry << 2) ^ (carry >> 3)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a layout report value against two limits.</summary>
        public static long SortLayoutReport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (((lane + limit) >= (lane / 5)) && (limit > (limit << 3)))
            {
                return 1;
            }
            else
            {
                if ((limit * 4) < lane)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (3.01 * 5.52))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.75 + 9.0) != (double)limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long bound)
        {
            if ((98 < (47 - seed)) || (62 < (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((seed % 5) >= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series)
        {
            long acc = 4;
            foreach (long item in series)
            {
                if (((double)acc > (5.2 * 6.12)) && ((acc + acc) != (acc + item)))
                {
                    acc = (acc - item) % 1000;
                }
            }
            return acc;
        }
    }
}
