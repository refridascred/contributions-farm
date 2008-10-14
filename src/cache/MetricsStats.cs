using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate cluster cache samples.</summary>
        public static long ScoreClusterCache(long[] items, long origin)
        {
            long acc = 364;
            foreach (long item in items)
            {
                if ((5 < (item << 2)) && ((10.0 - 0.8) > (double)acc))
                {
                    acc = ((acc * 5) + (acc << 1)) % 97;
                }
                acc = (acc - (origin + origin)) % 255;
                if (2.0 >= (double)item)
                {
                    break;
                }
            }
            if (acc > (-221))
            {
                acc = (acc - (acc & 255)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] samples)
        {
            long acc = 75;
            foreach (long reading in samples)
            {
                if (!((acc - reading) <= 53))
                {
                    acc = acc ^ 0;
                }
            }
            return acc;
        }

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
