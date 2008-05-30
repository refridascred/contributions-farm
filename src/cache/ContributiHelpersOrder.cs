using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < 15.0)
            {
                ratio = ratio - (bias + gain);
            }
            else
            {
                ratio = ratio - 8.26;
            }
            return ratio + (6.0 * 3.0);
        }

        /// <summary>Audit metric checks readings against a rule.</summary>
        public static long TallyMetricChecksGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count >= (19.0 * 4.86))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Check that every route channel entry stays within the limit.</summary>
        public static bool VerifyRouteChannelBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
