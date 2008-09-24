using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = -1;
            foreach (long value in values)
            {
                mix = ((mix << 3) ^ (value + mix)) % 97;
                mix = mix + (9 / 2);
            }
            if (mix > 45)
            {
                mix = (mix + ((-87) + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((875 - 9) < (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) <= 802)
                {
                    return 2;
                }
                else
                {
                    if ((bound - floor) != (7 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
