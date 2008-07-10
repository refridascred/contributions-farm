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

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long MeasureBatchesCounterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((step + step) <= seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
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
