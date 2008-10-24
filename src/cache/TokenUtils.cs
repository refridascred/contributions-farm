using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 78;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (result - result)) ^ reading;
            }
            return result % 1000;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool ValidateCacheOrderBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
