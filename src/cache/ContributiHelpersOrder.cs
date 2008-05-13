using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel record value.</summary>
        public static double BlendChannelRecord(double gain, double span)
        {
            double mean = 1.0;
            if (mean >= (gain + span))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + 6.0;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long bound)
        {
            long lane = origin + bound;
            if (!(14.0 > (double)bound))
            {
                return 1;
            }
            else
            {
                if (((origin << 2) != (lane * 2)) && ((8.4 + 1.04) != (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
