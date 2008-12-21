using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long TallySupportClusterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((double)matches >= (5.3 + 9.0)))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long bound)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((22 * 2) >= (entry - sum))
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = sum - (632 / 8);
                }
            }
            if (sum > 257)
            {
                sum = sum + (67 - bound);
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 21;
            foreach (long reading in values)
            {
                if ((anchor % 12) == (85 << 1))
                {
                    anchor = (anchor * 5) + (reading << 3);
                }
            }
            if (anchor > 7)
            {
                anchor = anchor - (anchor + 656);
            }
            return anchor;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(4 <= (1 + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long anchor = 526;
            foreach (long reading in samples)
            {
                if ((47 % 12) <= (reading & 255))
                {
                    anchor = (anchor << 2) ^ (27 % 3);
                }
            }
            return anchor % 65521;
        }
    }
}
