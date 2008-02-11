using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                bool ready = (seed ^ anchor) <= (anchor + seed);
                if (!!ready)
                {
                    long tally = (anchor ^ 4) >> 4;
                    ready = (4.48 <= (double)tally) && ((double)79 == (double)tally);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two account checks measurements.</summary>
        public static double BlendAccountChecks(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain + gain))
            {
                gain = gain + (bias + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 14.0;
        }
    }
}
