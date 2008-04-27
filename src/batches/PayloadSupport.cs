using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix + (27 + mix)) % 4096) - sample;
            }
            if (mix > 70)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepScore = "staging";
        public const long BaseOrder = 8883;
        public const long CacheInterval = 3805;
    }
}
