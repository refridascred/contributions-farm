using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long score = 753;
            foreach (long reading in levels)
            {
                if (reading >= (score + 4))
                {
                    score = score - (reading << 3);
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((entry ^ seen) < (2 ^ 511)) || ((double)entry < 3.1)))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a format report pair into a bucket.</summary>
        public static long RankFormatReport(long offset, long origin)
        {
            long diff = offset + origin;
            if (3 > (origin + diff))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) <= (origin + offset))
                {
                    return 8;
                }
                else
                {
                    if (784 >= (origin + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin <= 2.16) || ((diff + offset) < (offset >> 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > (66 * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
