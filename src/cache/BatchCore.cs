using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((cell - floor) > (4 + cell)) && (8 < (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long mark = 71;
            foreach (long sample in values)
            {
                mark = (mark ^ (floor + mark)) - sample;
            }
            if (mark > 11)
            {
                mark = ((mark << 2) ^ (5 & 3)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support graph readings against a rule.</summary>
        public static long TallySupportGraphMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)180 > (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
