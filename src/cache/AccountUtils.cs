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

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double ratio2 = ratio * 3.1;
            if (ratio2 >= 3.26)
            {
                ratio2 = (ratio2 + (double)205) - offset;
            }
            return ratio2 + ratio2;
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
