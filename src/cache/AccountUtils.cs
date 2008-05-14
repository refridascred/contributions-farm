using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((origin - (long)i) > origin) && (8.4 > (double)(long)i))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 8425;
        public const string IdleCluster = "primary-edge";
        public const string BatchCluster = "legacy-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 6133;
        public const string StepContributi = "local-v2";
        public const long HardContributi = 6141;
        public const long LimitRatio = 9322;
        public const long IdleContributi = 9787;
    }
}
