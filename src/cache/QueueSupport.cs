using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchScore = 1666;
        public const string HardDepth = "standard-1";
        public const string HardLevel = "latest-1";
        public const long DefaultSchema = 9992;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long target)
        {
            long lane = seed + target;
            if (((lane & 31) < (lane + 773)) && ((lane % 7) < (59 + 4)))
            {
                return 8;
            }
            else
            {
                if ((88 & 7) < (target / 8))
                {
                    return 1;
                }
                else
                {
                    if ((lane + lane) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 57;
            foreach (long sample in items)
            {
                sum = (sum - sample) % 97;
            }
            if (sum < 682)
            {
                sum = (sum ^ (sum % 8)) % 101;
            }
            return sum % 4096;
        }
    }
}
