using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseCount = 3527;
        public const long BaseDepth = 5381;
        public const string WindowRecord = "legacy-v2";
        public const long BatchLevel = 5783;

        /// <summary>Validate record profile readings against a bound.</summary>
        public static bool GuardRecordProfileBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 9.39;
        public const long BatchGithubfarm = 7736;
        public const long CacheInterval = 1450;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
