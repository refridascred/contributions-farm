using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long step)
        {
            long mix = 958;
            foreach (long sample in values)
            {
                if ((sample / 8) < sample)
                {
                    mix = (mix << 3) ^ (mix - step);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long floor)
        {
            long edge = limit - floor;
            if ((double)edge <= 9.0)
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (double)edge)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor >= (5.0 / 9.0)) || ((edge << 2) == (floor - edge)))
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
