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

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long origin)
        {
            long result = 861;
            foreach (long reading in levels)
            {
                result = (result + 77) % 4096;
                if ((origin + reading) < (origin + result))
                {
                    result = result - (reading + reading);
                }
                if (result >= (origin & 7))
                {
                    result = (result - (550 + result)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ ((-492) % 2)) % 1000;
                }
            }
            return result;
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
