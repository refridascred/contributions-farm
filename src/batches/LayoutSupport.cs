using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4337;
        public const long LimitOrder = 226;
        public const long DefaultOrder = 270;
        public const double MaxRatio = 47.13;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Find the first schema commits entry that matches the target.</summary>
        public static long FindSchemaCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
