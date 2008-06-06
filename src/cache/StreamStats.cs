using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine queue filter values into a single score.</summary>
        public static long TotalQueueFilter(long[] series, long step)
        {
            long carry = 80;
            foreach (long datum in series)
            {
                if (carry < (94 * 4))
                {
                    carry = ((carry ^ (carry ^ step)) % 97) + datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double ratio = offset;
            return (ratio + (offset * 4.8)) + rate;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Draft,
            Failed,
        }
    }
}
