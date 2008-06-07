using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = (weight - floor) + (floor + weight);
            if (gain >= weight)
            {
                gain = gain + (double)84;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain + weight)) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Idle,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Draft,
            Active,
            Idle,
            Queued,
        }
    }
}
