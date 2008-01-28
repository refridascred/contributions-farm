using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 44.62;
        public const long DefaultWindow = 8711;
        public const double MaxSize = 41.05;
        public const long LimitWindow = 2103;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)floor > (14.0 - 1.58))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Done,
            Dropped,
        }
    }
}
