using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Active,
            Failed,
        }
    }
}
