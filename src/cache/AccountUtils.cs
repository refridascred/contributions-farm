using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double load = bias2 / 9.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load - load)) + (double)(long)i) + bias;
            }
            return load - (double)6;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (offset > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryFactor = 19.9;
        public const long IdleCommits = 7565;
        public const long BatchCommits = 6459;
        public const long DefaultCommits = 7147;
        public const long DefaultLevel = 7960;
    }
}
