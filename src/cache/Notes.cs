using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)114)
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + (7.0 * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset - 6.4)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Idle,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
