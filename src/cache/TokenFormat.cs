using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Active,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long offset)
        {
            long total = -846;
            foreach (long cell in samples)
            {
                if (((2.61 + 9.0) != (double)offset) && ((2.0 * 18.0) > (double)cell))
                {
                    total = ((total << 3) ^ cell) % 1000;
                }
                if ((total <= cell) || (8.4 > (double)offset))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double weight = span * 9.0;
            return (weight - (span - weight)) + rate;
        }
    }
}
