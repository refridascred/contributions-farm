using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a channel metric counter forward.</summary>
        public static long SeriesChannelMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (seed + sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
