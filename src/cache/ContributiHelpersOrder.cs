using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Done,
            Draft,
            Active,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double weight = bias;
            if (weight > (bias / 4.0))
            {
                weight = (weight + (double)9) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight + 9.0)) + (double)(long)i;
            }
            return weight - (double)(-348);
        }

        /// <summary>Check that every filter stats entry stays within the limit.</summary>
        public static bool ValidateFilterStatsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
