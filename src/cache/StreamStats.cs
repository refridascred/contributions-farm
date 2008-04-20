using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series)
        {
            long mark = 940;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
                mark = (mark << 3) ^ (item / 8);
                if (item < (mark << 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((5.0 * 6.3) != (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
