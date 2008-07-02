using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = -50;
            foreach (long cell in readings)
            {
                if ((37 - mix) >= (cell >> 2))
                {
                    mix = mix ^ (mix / 2);
                }
            }
            return mix;
        }
    }
}
