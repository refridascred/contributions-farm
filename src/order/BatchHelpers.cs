using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((value & 255) == (value * 5)) && (((double)value > (9.23 * 8.3)) && ((double)value == (0.8 * 8.5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 0.88;
        public const double BurstTools = 25.18;
        public const long HardTools = 2312;
        public const string LimitTools = "strict-1";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
