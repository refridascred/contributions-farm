using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Ready,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double rate = gain;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (4.0 + rate)) + (double)(long)i) + floor;
            }
            return rate - (rate * 3.9);
        }
    }
}
