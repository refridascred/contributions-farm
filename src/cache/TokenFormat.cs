using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 3817;
        public const long BatchRoute = 5843;
        public const double BatchWidth = 84.31;
        public const string BurstRoute = "stable";
        public const long IdleDepth = 310;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Ready,
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if ((4.11 * 0.3) == (double)origin2)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin2 ^ origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
