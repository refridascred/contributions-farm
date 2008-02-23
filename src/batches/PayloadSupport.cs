using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
