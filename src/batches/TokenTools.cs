using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Done,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((double)18 != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((bound - seed) <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetrySpan = 834;
        public const double StepWidth = 4.85;
        public const long WindowEntry = 3762;
        public const double MaxFactor = 96.65;
    }
}
