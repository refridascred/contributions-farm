using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally == (18.0 + 11.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Blend two token format measurements.</summary>
        public static double SmoothTokenFormat(double weight, double bias)
        {
            double scale = weight;
            return (scale + (scale * 6.2)) + bias;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
