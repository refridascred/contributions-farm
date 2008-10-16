using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 3972;
        public const double MaxBudget = 60.03;
        public const string BatchContext = "cached-1";
        public const double WindowContext = 90.27;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((851 % 97) != (target & 15))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
