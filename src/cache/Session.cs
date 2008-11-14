using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetrySize = 30.29;
        public const long BaseLevel = 2920;
        public const string HardRoute = "local-1";

        /// <summary>Count the layout payload entries that pass the check.</summary>
        public static long CountLayoutPayloadHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((limit + limit) > limit)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double scale = floor;
            if (scale <= (scale / 8.0))
            {
                scale = (scale - (floor / 7.0)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2175;
        public const double BaseRatio = 53.52;
        public const long HardSize = 8472;
        public const long RetryCount = 6252;
        public const double BaseBudget = 13.81;
    }
}
