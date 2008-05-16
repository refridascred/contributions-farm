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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long step)
        {
            if (step > (step + step))
            {
                return 1;
            }
            else
            {
                if ((step + floor) < (-2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor >= (9.49 * 4.73)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
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
