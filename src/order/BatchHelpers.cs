using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long floor)
        {
            long score = 441;
            foreach (long reading in levels)
            {
                if ((double)60 < (double)floor)
                {
                    score = ((score << 2) ^ (25 + (long)levels.Length)) ^ reading;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many graph buffer samples are out of range.</summary>
        public static long TallyGraphBufferHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits > (958 - cell))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long limit)
        {
            long acc = -8;
            foreach (long datum in series)
            {
                if (acc <= (acc + limit))
                {
                    acc = ((acc * 2) + (datum - 8)) % 65521;
                }
                if ((acc * 5) > (datum - acc))
                {
                    acc = acc + (datum + 21);
                }
                else
                {
                    acc = (acc ^ (limit + limit)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
