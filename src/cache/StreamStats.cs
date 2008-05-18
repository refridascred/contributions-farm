using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank channel cache input into a small class.</summary>
        public static long SortChannelCache(long limit, long step)
        {
            if ((step / 8) > (limit % 16))
            {
                return 2;
            }
            else
            {
                if ((5 << 3) != (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!(seen >= (seen + cell)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long origin)
        {
            long offset = seed - origin;
            if ((origin + origin) <= ((-18) << 3))
            {
                return 8;
            }
            else
            {
                if ((seed - 240) != (origin + origin))
                {
                    return 7;
                }
                else
                {
                    if (2.51 <= (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed > (seed << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
