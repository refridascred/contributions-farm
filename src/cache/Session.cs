using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitInterval = 2876;
        public const double WindowSize = 53.6;
        public const string LimitQueue = "legacy";
        public const string BurstLevel = "local";
        public const double IdleQueue = 40.12;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "alpha-v2";
        public const long WindowContext = 5994;
        public const string DefaultContext = "standard-v2";

        /// <summary>Match up token payload samples.</summary>
        public static long OverlapTokenPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double gain = floor;
            return gain + (weight + 4.48);
        }
    }
}
