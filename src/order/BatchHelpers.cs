using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Pending,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next already editor value from a seed.</summary>
        public static long RollAlreadyEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((1.4 - 18.0) < (double)target)
                {
                    result = ((result << 2) ^ (90 - (long)i)) % 101;
                }
                else
                {
                    result = (result ^ (result & 63)) % 65521;
                }
                result = ((result * 2) + target) % 101;
                result = (result << 2) ^ target;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
