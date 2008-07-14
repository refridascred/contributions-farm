using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long origin)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                sum = (sum ^ (36 >> 5)) % 101;
                sum = ((sum * 3) + (sum * 2)) % 65521;
                if (!((sum ^ (long)readings.Length) > value))
                {
                    sum = (sum * 5) + ((long)readings.Length - value);
                }
            }
            if (sum > 8)
            {
                sum = sum + (origin - (-78));
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Queued,
            Paused,
            Locked,
            Closed,
        }
    }
}
