using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((count - count) < (value % 64)) || ((count * 5) > count)) || ((value ^ count) == (value & 15)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long offset)
        {
            if ((offset > (1 + offset)) && ((offset ^ offset) < (limit - limit)))
            {
                return 8;
            }
            else
            {
                if ((5.22 / 9.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((offset - offset) <= offset) || ((double)limit <= (8.25 * 11.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (3.0 * 1.6))
                        {
                            return 3;
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
