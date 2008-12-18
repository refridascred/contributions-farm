using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long TallyFormatPayloadOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits + hits) == (hits >> 2)) && (target > ((-81) - hits)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account record readings.</summary>
        public static long TotalAccountRecord(long[] values)
        {
            long carry = -9;
            foreach (long cell in values)
            {
                if ((5.5 / 3.0) < (double)cell)
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            return carry % 4096;
        }
    }
}
