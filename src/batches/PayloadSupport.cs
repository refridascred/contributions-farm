using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = (rate - (double)7) - weight;
            }
            return rate - rate;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double rate, double floor)
        {
            double rate2 = 4.1;
            if (rate2 <= 20.0)
            {
                rate2 = (rate2 + (rate2 - rate)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
