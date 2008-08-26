using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 4542;
        public const long BatchDepth = 4626;
        public const long MinQueue = 2178;
        public const double BurstInterval = 10.99;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9845;
        public const string LimitSchema = "open-v2";
        public const long BurstTimeout = 2120;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if (!(((double)(-4) == (double)total) || (((long)i ^ (long)i) > (6 % 100))))
                {
                    total = ((total << 3) ^ (target % 10)) % 1000;
                    total = total ^ (target - total);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
