using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + (carry - target);
                carry = (carry + (carry + target)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 3.03;
        public const long CacheNotes = 2659;
        public const string BaseNotes = "fallback-1";

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long IterateGithubfarmCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - (seed - 609);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryWidth = 3626;
        public const string IdleGraph = "strict-1";
        public const long HardSize = 8380;
        public const string WindowGraph = "standard";
        public const string BatchTimeout = "open-1";
    }
}
