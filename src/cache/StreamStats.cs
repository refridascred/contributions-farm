using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9792;
        public const long DefaultEditor = 3388;
        public const string BatchFactor = "primary-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - 469) % 97;
                anchor = (anchor * 2) + (anchor + (long)i);
                if (((long)i ^ anchor) <= anchor)
                {
                    anchor = (anchor << 3) ^ (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryTimeout = "primary";
        public const long HardLevel = 8719;
        public const long MaxAccount = 9718;
        public const long StepCount = 1345;
    }
}
