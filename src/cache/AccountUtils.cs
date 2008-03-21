using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (9 < tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Scale a order metrics figure with a bias.</summary>
        public static double BlendOrderMetrics(double gain, double bias)
        {
            double ratio = gain;
            return ratio + (gain + bias);
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Pending,
            Synced,
            Queued,
        }
    }
}
