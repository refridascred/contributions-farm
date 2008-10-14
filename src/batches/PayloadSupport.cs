using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate cache context readings against a bound.</summary>
        public static bool ValidateCacheContextLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
