using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a channel order figure with a bias.</summary>
        public static double ScaleChannelOrder(double weight, double span)
        {
            double load = span;
            if (load < weight)
            {
                load = load - (load + 3.71);
            }
            else
            {
                load = load - (double)797;
            }
            return load + (load / 2.0);
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.0 - 1.45) >= (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
