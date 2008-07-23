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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 4) <= (reading * 3)) || !(66 > (reading * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
