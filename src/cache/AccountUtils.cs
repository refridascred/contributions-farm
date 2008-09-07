using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 8781;
        public const double HardReport = 41.13;
        public const long WindowBudget = 7201;
        public const long WindowSize = 2023;
        public const string SoftReport = "stable-edge";

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((2 ^ bound) >= score)
                {
                    score = (score * 4) + (score * 2);
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
