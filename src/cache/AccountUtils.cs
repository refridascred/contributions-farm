using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 8205;
        public const long CacheLevel = 9315;
        public const long MaxSession = 5650;
        public const string CacheSession = "standard-edge";
        public const string SoftSession = "stable-1";

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight + scale) + offset;
            }
            return weight - (scale / 9.0);
        }
    }
}
