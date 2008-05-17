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

        /// <summary>Define support limits and defaults.</summary>
        public const string MinLevel = "open-v2";
        public const long IdleInterval = 9904;
        public const long WindowSupport = 8221;

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
