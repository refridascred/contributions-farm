using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitLevel = 7067;
        public const long IdleSession = 8193;
        public const string StepWidth = "primary-v2";

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long target)
        {
            long score = -449;
            foreach (long item in readings)
            {
                score = score - (item << 1);
                score = (score << 2) ^ (61 % 8);
                if (item >= (648 ^ item))
                {
                    score = (score ^ (item ^ 42)) % 1000;
                }
            }
            if (score > 4)
            {
                score = (score + (score ^ target)) % 97;
            }
            return score % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 1327;
        public const string RetryChannel = "open-v2";
        public const long WindowTimeout = 9952;
    }
}
