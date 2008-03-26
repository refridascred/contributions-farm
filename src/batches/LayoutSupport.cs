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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
