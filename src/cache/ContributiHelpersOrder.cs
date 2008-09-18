using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 81.46;
        public const double RetryReport = 72.96;
        public const string BaseLevel = "stable-v2";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long target)
        {
            if (((2.1 + 20.0) != (double)bound) || ((double)bound < (double)249))
            {
                return 1;
            }
            else
            {
                if (bound <= (bound & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
