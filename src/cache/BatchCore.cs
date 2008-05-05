using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Project the next tools profile value.</summary>
        public static double BlendToolsProfile(double bias, double span)
        {
            double weight = (double)(5 / 9);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (double)(long)i) - bias) - span;
            }
            return weight + (double)691;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
