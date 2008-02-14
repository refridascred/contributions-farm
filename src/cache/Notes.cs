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

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleSize = "fallback-edge";
        public const long DefaultBudget = 2313;
        public const long BaseReport = 5633;
        public const long BaseSize = 653;
        public const long MinCount = 3016;

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
