using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 53.49;
        public const long SoftLevel = 1646;
        public const string BurstDepth = "stable-1";

        /// <summary>Validate order command readings against a bound.</summary>
        public static bool ValidateOrderCommandBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 << 2) >= count)
                {
                    count = ((count + 2) ^ cell) + target;
                }
            }
            return count;
        }
    }
}
