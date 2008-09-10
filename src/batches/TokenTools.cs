using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double rate, double bias)
        {
            double mean = 7.27 * 13.0;
            if (mean > (rate / 6.0))
            {
                mean = (mean + rate) - bias;
            }
            return mean + (rate / 2.0);
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long CountClusterQueueMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item > (2.58 + 1.64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
