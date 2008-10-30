using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchSpan = 24.35;
        public const long WindowWidth = 8086;
        public const string BaseInterval = "primary";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Idle,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
