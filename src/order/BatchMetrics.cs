using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit contributi stream readings against a rule.</summary>
        public static long CountContributiStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((24 - hits) >= (item << 2))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster account entry stays within the limit.</summary>
        public static bool GuardClusterAccountBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values)
        {
            long acc = -227;
            foreach (long value in values)
            {
                acc = ((acc * 4) + value) % 65521;
            }
            if (acc < 1)
            {
                acc = acc - (41 / 2);
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading < (seen + seen))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((5 & 63) <= (210 - origin))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits - 231) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
