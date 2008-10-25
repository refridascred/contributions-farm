using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double rate = 8.63;
            if (rate <= (floor + rate))
            {
                rate = (rate + rate) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (floor / 6.0);
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Closed,
            Locked,
            Synced,
        }
    }
}
