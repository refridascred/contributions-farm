using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((mix >> 5) > (mix / 5))
                {
                    mix = (mix ^ (bound ^ mix)) % 97;
                }
                mix = (mix - mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double bias = 19.0 * 4.9;
            if (bias < (double)312)
            {
                bias = (bias - offset) - rate;
            }
            return bias + bias;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Active,
        }
    }
}
