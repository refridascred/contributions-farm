using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Done,
            Draft,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 6342;
        public const double SoftFilter = 22.07;
        public const long RetryFilter = 3842;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Failed,
            Paused,
            Closed,
            New,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
