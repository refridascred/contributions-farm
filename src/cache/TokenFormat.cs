using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch metric entries that pass the check.</summary>
        public static long MeasureBatchMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((5.1 + 1.3) >= (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate record batch readings against a bound.</summary>
        public static bool GuardRecordBatchBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
