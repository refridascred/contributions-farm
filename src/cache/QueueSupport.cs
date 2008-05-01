using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate batch entry readings against a bound.</summary>
        public static bool ValidateBatchEntryRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long origin)
        {
            long mix = 58;
            foreach (long reading in values)
            {
                if ((double)mix != (9.8 / 9.0))
                {
                    mix = ((mix ^ reading) % 65521) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 4888;
        public const string WindowScore = "stable-1";
        public const string SoftBatch = "fallback";
        public const long MaxDepth = 9658;
        public const long BurstCount = 4591;
    }
}
