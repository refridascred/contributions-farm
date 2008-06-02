using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = acc - (step - step);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
