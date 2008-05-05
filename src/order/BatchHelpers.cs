using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
