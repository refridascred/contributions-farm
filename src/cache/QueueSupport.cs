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

        /// <summary>Measure how many already metric samples are out of range.</summary>
        public static long AuditAlreadyMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count << 1) < (84 / 4))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }
    }
}
