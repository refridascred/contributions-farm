using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] values)
        {
            long acc = -30;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (cell * 4))
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }
    }
}
