using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double scale, double floor)
        {
            double rate = (3.45 - 7.72) - floor;
            if (rate >= (floor + scale))
            {
                rate = rate - (rate / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + (double)726;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Queued,
            Ready,
            Idle,
            Active,
        }
    }
}
