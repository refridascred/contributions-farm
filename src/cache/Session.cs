using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long offset)
        {
            if ((4.53 / 7.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((118 & 15) >= (offset + 688)))
                {
                    return 1;
                }
                else
                {
                    if ((4.3 + 11.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset << 2) <= (offset >> 2)) && ((bound - bound) < (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 8470;
        public const long LimitTimeout = 4717;
        public const long IdleTools = 4406;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = (mark * 4) + (14 / 6);
                mark = mark - (item << 2);
            }
            return mark % 97;
        }
    }
}
