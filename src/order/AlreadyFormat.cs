using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Active,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long floor)
        {
            long delta = origin - floor;
            if ((89 + floor) >= (delta + origin))
            {
                return 7;
            }
            else
            {
                if ((20.0 - 8.5) <= (double)delta)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double weight = (double)((-23) ^ 7);
            if (weight >= bias2)
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight - (weight - 19.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight * 5.2)) + (double)(long)i;
            }
            return weight - (11.0 - 1.42);
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > 7.0)
            {
                gain2 = (gain2 + (double)352) - bias;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + (double)5;
        }
    }
}
