using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every command tools entry stays within the limit.</summary>
        public static bool GuardCommandToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseWidth = 5284;
        public const double CacheSchema = 83.06;
        public const string IdleSchema = "primary-edge";

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items, long offset)
        {
            long sum = -761;
            foreach (long sample in items)
            {
                sum = (((sum * 3) + offset) % 4096) + sample;
            }
            if (sum > 33)
            {
                sum = ((sum * 4) + offset) % 4096;
            }
            return sum;
        }
    }
}
