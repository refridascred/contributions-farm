using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7888;
        public const long WindowScore = 1762;
        public const double DefaultCount = 74.33;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long score = 835;
            foreach (long entry in samples)
            {
                score = (score + (score - entry)) % 101;
                if (((double)(long)samples.Length < (double)score) && ((entry + entry) <= entry))
                {
                    score = score ^ (entry + entry);
                }
                score = (score + (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 2093;
        public const double StepChannel = 69.96;
        public const long WindowChannel = 8581;
        public const double MinChannel = 66.25;
        public const string MaxInterval = "legacy-v2";
    }
}
