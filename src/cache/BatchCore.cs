using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 1926;
        public const long RetryOrder = 7616;
        public const string SoftOrder = "open-edge";
        public const string WindowOrder = "primary-v2";
        public const long DefaultCount = 3299;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total + (total ^ total)) % 65521;
                total = (total ^ (total >> 5)) % 97;
                total = ((total * 2) + total) % 1000;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
