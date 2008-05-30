using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.4 * 3.3) >= (double)sample)
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command buffer value against two limits.</summary>
        public static long ClassifyCommandBuffer(long offset, long origin)
        {
            long delta = offset - origin;
            if ((7.2 * 1.78) < (double)offset)
            {
                return 2;
            }
            else
            {
                if (((double)offset == (5.7 / 5.0)) && (offset >= 26))
                {
                    return 8;
                }
                else
                {
                    if (origin > (delta % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((520 ^ origin) > (origin - offset)) && (origin <= (398 >> 3)))
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
        }
    }
}
