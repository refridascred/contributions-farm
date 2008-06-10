using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = gain;
            if (drift >= (drift / 2.0))
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Dropped,
            Closed,
            Queued,
        }
    }
}
