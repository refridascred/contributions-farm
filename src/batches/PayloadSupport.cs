using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally % 24) > (item << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double weight = 9.63;
            for (int i = 0; i < 4; i++)
            {
                weight = (((weight - (double)12) - (double)(long)i) - gain) + floor;
            }
            return weight - (double)987;
        }
    }
}
