using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a order account reading.</summary>
        public static double ProjectOrderAccount(double ratio, double floor)
        {
            double bias = (16.0 + floor) / 2.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - bias) - (double)(long)i) - ratio;
            }
            return bias + (floor / 4.0);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)floor > (18.0 * 8.6))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
