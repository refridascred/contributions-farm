using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleSize = "strict-1";
        public const double MaxFactor = 6.94;
        public const string HardStream = "fallback-v2";
        public const string MaxStream = "stable-v2";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value != (20.0 * 4.4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
