using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double mean = (double)(9 - 91);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - span) + (double)(long)i) + gain;
            }
            return mean + (mean - 2.25);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
