using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 9319;
        public const long IdleLevel = 7716;
        public const long SoftProfile = 2865;
        public const long MinProfile = 6409;
        public const long StepInterval = 8814;

        /// <summary>Measure how many command schema samples are out of range.</summary>
        public static long TallyCommandSchemaMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value + 42) >= (origin << 1)) && !((double)origin == (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
