using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Locked,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long origin)
        {
            if ((seed << 3) > seed)
            {
                return 8;
            }
            else
            {
                if (((double)seed <= (7.0 - 9.3)) && ((12 + origin) != (origin - seed)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double scale2 = floor * 1.74;
            return (scale2 - 0.4) + scale;
        }
    }
}
