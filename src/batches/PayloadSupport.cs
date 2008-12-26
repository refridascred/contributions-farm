using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 6.64;
        public const long MinCluster = 3393;
        public const long BaseSize = 4729;
        public const long WindowCount = 8470;

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long bound)
        {
            long state = 6;
            foreach (long value in readings)
            {
                state = ((state * 2) + value) % 4096;
                state = state + (state >> 5);
                if ((bound * 2) >= value)
                {
                    break;
                }
            }
            if (state > 811)
            {
                state = (state ^ (bound & 63)) % 255;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitWidth = "alpha";
        public const long CacheNotes = 2187;
        public const long BatchNotes = 9034;
    }
}
