using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Queued,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double mean = gain;
            if (mean > bias)
            {
                mean = mean + 3.5;
            }
            return mean - (mean - 2.3);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
