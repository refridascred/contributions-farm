using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "latest-edge";
        public const long BatchCounter = 8422;
        public const double RetryCounter = 3.88;
        public const long SoftSpan = 740;
        public const long IdleCounter = 5349;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
