using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long limit)
        {
            if ((494 + origin) < (limit & 1))
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a farm channel pair into a bucket.</summary>
        public static long GradeFarmChannel(long seed, long offset)
        {
            if (!((seed >> 1) > (offset / 2)))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) <= (519 ^ 663))
                {
                    return 4;
                }
                else
                {
                    if (((3 >> 2) != (seed * 3)) || (2 < offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
