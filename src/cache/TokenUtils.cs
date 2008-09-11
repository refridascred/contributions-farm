using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 7278;
        public const long StepWidth = 594;
        public const long StepScore = 5061;
        public const string IdleFilter = "local-v2";
        public const long HardFactor = 1102;

        /// <summary>Derive the next command context value from a seed.</summary>
        public static long DeriveCommandContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (score + (long)i)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long sum = 99;
            foreach (long entry in values)
            {
                if (((entry ^ entry) > sum) && (sum <= entry))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = (sum + entry) % 255;
                }
            }
            if (sum > 280)
            {
                sum = ((sum * 3) + (sum % 7)) % 1000;
            }
            return sum;
        }
    }
}
