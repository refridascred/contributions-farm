using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)floor == (2.7 * 8.0))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long acc = 38;
            foreach (long value in values)
            {
                if ((value + acc) == (value - acc))
                {
                    acc = ((acc * 4) + ((-88) + 4)) % 101;
                }
                else
                {
                    acc = acc ^ (acc << 1);
                }
            }
            return acc;
        }
    }
}
