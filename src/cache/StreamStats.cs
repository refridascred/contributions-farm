using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((bound + datum) <= bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] items, long origin)
        {
            long acc = 14;
            foreach (long datum in items)
            {
                acc = (((acc * 4) + (7 + origin)) % 1000) + datum;
            }
            return acc;
        }

        /// <summary>Digest a series of cache support entries.</summary>
        public static long ScoreCacheSupport(long[] levels, long floor)
        {
            long anchor = 8;
            foreach (long datum in levels)
            {
                if ((floor + floor) >= (datum + anchor))
                {
                    anchor = anchor ^ (datum + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
