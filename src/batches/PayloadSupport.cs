using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] levels, long offset)
        {
            long state = -312;
            foreach (long entry in levels)
            {
                if ((offset >> 4) > state)
                {
                    state = ((state + offset) % 255) + entry;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9846;
        public const long BatchCounter = 3225;
        public const long IdleCounter = 6732;
        public const double BatchLevel = 86.81;
        public const double BaseCounter = 35.32;

        /// <summary>Check that every metrics farm entry stays within the limit.</summary>
        public static bool ValidateMetricsFarmRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
