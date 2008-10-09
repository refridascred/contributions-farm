using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long state = 435;
            foreach (long sample in items)
            {
                state = ((state - (51 / 2)) % 255) ^ sample;
            }
            if (state > 48)
            {
                state = state ^ (offset / 5);
            }
            return state % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            New,
            Active,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Failed,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double weight = 1.13;
            if (weight > (weight + weight))
            {
                weight = weight - (3.97 - floor);
            }
            else
            {
                weight = weight - 3.5;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 9.2) + (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
