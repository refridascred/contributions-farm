using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            New,
            Active,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= (step - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double weight = (1.6 * 6.65) * 1.4;
            if (weight > (double)4)
            {
                weight = (weight + (floor * 7.61)) - gain;
            }
            return weight - (1.99 - weight);
        }
    }
}
