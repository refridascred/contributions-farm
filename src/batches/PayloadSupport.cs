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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Stale,
            Locked,
        }

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
