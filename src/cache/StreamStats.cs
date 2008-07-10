using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long limit)
        {
            if ((bound << 3) <= bound)
            {
                return 1;
            }
            else
            {
                if ((46 % 60) <= (16 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 63) <= (limit + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item > (1.0 + 20.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((diff + seed) > ((-1) << 2))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
