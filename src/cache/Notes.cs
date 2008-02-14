using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((9.44 / 8.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 79.87;
        public const double MaxLayout = 50.17;
        public const long HardLayout = 6588;
        public const long RetryLayout = 6081;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Queued,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
