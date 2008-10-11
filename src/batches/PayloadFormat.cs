using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Done,
            Locked,
            Queued,
            New,
        }

        /// <summary>Fold a list of session metrics readings.</summary>
        public static long TotalSessionMetrics(long[] levels, long origin)
        {
            long anchor = 826;
            foreach (long value in levels)
            {
                if ((double)anchor > (0.5 / 7.0))
                {
                    anchor = ((anchor ^ (origin & 1)) % 1000) + value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 12;
        public const long RetryWidth = 3465;
        public const double BurstInterval = 94.41;
        public const double BaseBuffer = 32.94;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
