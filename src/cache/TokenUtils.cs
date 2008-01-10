using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultLevel = 3554;
        public const long WindowGithubfarm = 8425;
        public const long BurstDepth = 5060;
        public const long StepGithubfarm = 4204;
        public const long RetryBudget = 7107;

        /// <summary>Accumulate cache profile samples.</summary>
        public static long TallyCacheProfile(long[] readings, long target)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = ((result * 3) + entry) % 65521;
            }
            if (result > 26)
            {
                result = ((result << 2) ^ target) % 65521;
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Dropped,
        }
    }
}
