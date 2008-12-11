using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long offset, long bound)
        {
            if ((bound & 15) <= offset)
            {
                return 3;
            }
            else
            {
                if (offset >= (offset << 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 0.6)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound <= (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ floor) + cell;
            }
            return mark % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
