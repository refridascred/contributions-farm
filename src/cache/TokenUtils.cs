using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] data, long step)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if (step <= (1 * 4))
                {
                    result = (result ^ ((long)data.Length >> 4)) % 4096;
                }
                else
                {
                    result = result - (step - result);
                }
                result = (result + entry) % 101;
            }
            return result % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardToken = "fallback-edge";
        public const long IdleToken = 4908;
        public const long MinBudget = 7070;
        public const double BatchInterval = 23.62;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Locked,
            Active,
            Queued,
        }
    }
}
