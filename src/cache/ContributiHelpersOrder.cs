using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double gain = offset;
            if (gain <= 7.77)
            {
                gain = (gain - (gain * 0.6)) + bias;
            }
            else
            {
                gain = gain + (offset / 3.0);
            }
            return gain + offset;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long step, long limit)
        {
            long lane = step - limit;
            if ((limit - lane) <= (lane << 2))
            {
                return 1;
            }
            else
            {
                if (!((double)lane == (1.83 - 1.5)))
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
