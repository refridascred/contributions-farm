using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 59;
            foreach (long item in values)
            {
                if ((carry + carry) > (carry / 7))
                {
                    carry = carry + (item / 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSpan = "cached-1";
        public const long MaxToken = 9126;
        public const long DefaultToken = 5271;
        public const long SoftToken = 8373;
        public const string StepInterval = "cached-v2";
    }
}
