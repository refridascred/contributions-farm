using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (18.0 >= (double)floor)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
