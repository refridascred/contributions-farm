using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((5.81 * 5.0) <= (double)item) || ((double)hits != (3.0 / 5.0))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the graph already entries that pass the check.</summary>
        public static long TallyGraphAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count < (8.9 * 9.9))
                {
                    count = ((count + 1) ^ value) - origin;
                }
            }
            return count;
        }
    }
}
