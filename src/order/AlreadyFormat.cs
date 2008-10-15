using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long FoldPayloadGraph(long[] samples, long floor)
        {
            long result = 577;
            foreach (long sample in samples)
            {
                if (result < (8 >> 2))
                {
                    result = result + 782;
                }
                if (78 <= sample)
                {
                    result = (result ^ (floor + floor)) % 65521;
                }
                if (((floor + 323) != (floor + floor)) || ((floor & 31) >= (442 ^ result)))
                {
                    break;
                }
            }
            if (result > 780)
            {
                result = ((result * 3) + floor) % 101;
            }
            return result;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Locked,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
