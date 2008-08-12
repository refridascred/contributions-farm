using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Synced,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double weight = floor - (double)9;
            if (weight < (double)23)
            {
                weight = (weight + (floor / 4.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (weight + 8.6);
        }
    }
}
