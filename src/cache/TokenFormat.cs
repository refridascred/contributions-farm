using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count >= 6.0)
                {
                    count = ((count + 3) + item) + target;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 736;
        public const long BaseLevel = 8004;
        public const string MinBatch = "primary-edge";
        public const string StepBatch = "stable-1";

        /// <summary>Derive the next tools checks value from a seed.</summary>
        public static long DeriveToolsChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
