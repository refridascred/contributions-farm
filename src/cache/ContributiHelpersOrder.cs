using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            long step = seed - floor;
            if (!((step * 4) <= (6 ^ seed)))
            {
                return 7;
            }
            else
            {
                if ((seed >> 2) >= floor)
                {
                    return 1;
                }
                else
                {
                    if (((-33) / 5) <= (step / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long origin)
        {
            long span = offset ^ origin;
            if ((origin >> 1) >= (offset + span))
            {
                return 5;
            }
            else
            {
                if (offset >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 692) >= (span << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 366;
            foreach (long sample in data)
            {
                if (((double)state == (6.0 * 7.2)) && ((double)sample <= (double)state))
                {
                    state = (state - (sample & 1)) % 65521;
                }
            }
            if (state > 972)
            {
                state = ((state * 2) + (state >> 3)) % 255;
            }
            return state % 4096;
        }
    }
}
