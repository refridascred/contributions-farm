using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long floor)
        {
            long mix = 74;
            foreach (long value in series)
            {
                mix = ((mix * 4) + (value - floor)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Ready,
            Dropped,
            Retry,
        }
    }
}
