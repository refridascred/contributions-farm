using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of order support readings.</summary>
        public static long CombineOrderSupport(long[] items, long floor)
        {
            long mix = 814;
            foreach (long reading in items)
            {
                if (773 > (mix - floor))
                {
                    mix = (mix - (reading + reading)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Stale,
            Synced,
            Idle,
        }
    }
}
