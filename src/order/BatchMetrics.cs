using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Queued,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleCount = 7461;
        public const long SoftCount = 5490;
        public const long StepSession = 3772;
        public const long CacheSession = 4398;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every stream buffer entry stays within the limit.</summary>
        public static bool CheckStreamBufferBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Queued,
            Failed,
            Synced,
        }
    }
}
