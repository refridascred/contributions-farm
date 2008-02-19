using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (772 > (3 + score))
                {
                    score = (score ^ bound) % 255;
                    continue;
                }
                else
                {
                    score = score ^ (bound + score);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 23.42;
        public const string SoftQueue = "latest-1";
        public const long StepQueue = 9384;
        public const long MinQueue = 7901;
        public const string WindowQueue = "fallback-edge";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Paused,
            Done,
        }
    }
}
