using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every account batches entry stays within the limit.</summary>
        public static bool ValidateAccountBatchesLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
