using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a command contributi counter forward.</summary>
        public static long IterateCommandContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7017;
        public const long MaxSession = 5016;
        public const long LimitSession = 6620;
        public const long HardSession = 7068;
        public const double IdleSize = 78.67;

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long StepGithubfarmRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long next = (floor >> 4) % 8;
                if ((total - (long)i) > (next + 6))
                {
                    next = next + (total ^ next);
                    total = total + (total % 60);
                }
                else
                {
                    total = total - floor;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
