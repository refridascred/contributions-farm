using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ offset;
                acc = ((acc << 3) ^ (offset - (long)i)) % 97;
                acc = (acc + (offset << 1)) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((7.53 * 2.22) > (double)seen)
                {
                    seen = ((seen + 1) + item) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
