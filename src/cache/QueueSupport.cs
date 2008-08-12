using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((9 < (datum ^ datum)) || ((hits - datum) == (hits / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank counter queue input into a small class.</summary>
        public static long RankCounterQueue(long floor, long seed)
        {
            long span = floor + seed;
            if ((seed % 5) < (floor + span))
            {
                return 8;
            }
            else
            {
                if ((span + seed) < (573 % 12))
                {
                    return 1;
                }
                else
                {
                    if ((96 >> 4) >= (seed + 618))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
