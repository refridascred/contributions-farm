using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((6.0 + 8.9) != (double)anchor)
                {
                    anchor = ((anchor * 4) + (511 * 4)) % 97;
                    anchor = (anchor + floor) % 1000;
                }
                if ((anchor * 3) < anchor)
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = (anchor - (anchor - (long)i)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long offset)
        {
            if (((-486) << 1) >= (offset - target))
            {
                return 5;
            }
            else
            {
                if ((10 + target) > (target / 3))
                {
                    return 8;
                }
                else
                {
                    if ((7.8 - 3.33) <= (double)target)
                    {
                        return 6;
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
