using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next counter checks value.</summary>
        public static double ScaleCounterChecks(double gain, double floor)
        {
            double gain2 = (double)((-10) + 554);
            if (gain2 < floor)
            {
                gain2 = gain2 - gain2;
            }
            else
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (floor * 4.1);
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double scale, double bias)
        {
            double weight = scale;
            if (weight < (bias / 6.0))
            {
                weight = weight - (double)948;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (6.8 - scale)) + (double)(long)i;
            }
            return weight + (double)28;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
