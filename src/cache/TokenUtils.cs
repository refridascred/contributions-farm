using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7736;
        public const string RetryBudget = "staging-edge";
        public const double StepScore = 44.78;

        /// <summary>Define window limits and defaults.</summary>
        public const long MinLevel = 9970;
        public const long HardWindow = 8859;
        public const string MaxLevel = "staging-1";
        public const long RetryWindow = 1261;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
