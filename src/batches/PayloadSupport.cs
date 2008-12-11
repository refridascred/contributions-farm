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

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 3) + ((long)i + bound);
                long slot = bound;
                if ((double)slot >= (double)bound)
                {
                    slot = ((slot << 3) ^ (slot + (long)i)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
