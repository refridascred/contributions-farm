using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(((double)matches < (7.0 * 1.87)) || ((matches + origin) > 26)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data)
        {
            long total = 800;
            foreach (long item in data)
            {
                if ((double)total == (8.0 / 9.0))
                {
                    total = ((total << 2) ^ (item + item)) % 4096;
                }
            }
            if (total < 981)
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long limit)
        {
            long slot = seed + limit;
            if (limit <= (seed / 5))
            {
                return 2;
            }
            else
            {
                if ((limit + slot) > 76)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long CountFormatBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Idle,
            Ready,
            Queued,
            Locked,
        }
    }
}
