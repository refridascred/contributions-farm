using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double mean = span;
            if (mean < (gain * 7.0))
            {
                mean = mean + span;
            }
            return mean - (span - gain);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
