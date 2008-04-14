using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "open-1";
        public const double WindowInterval = 20.63;
        public const long HardInterval = 5878;
        public const long StepBuffer = 9649;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score - (81 / 7);
                if ((29 + (-6)) != (target / 2))
                {
                    score = (score - target) % 255;
                }
                score = score + target;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
