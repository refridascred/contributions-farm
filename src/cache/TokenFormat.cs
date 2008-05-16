using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double bias2 = (offset * 4.37) * 6.8;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - bias;
            }
            return bias2 + (double)6;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryBudget = 6932;
        public const double IdlePayload = 31.15;
        public const long LimitInterval = 149;
        public const long WindowDepth = 6098;
        public const long BatchPayload = 4226;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(target > (83 + seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
