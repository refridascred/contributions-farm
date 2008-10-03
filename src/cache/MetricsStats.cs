using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] levels)
        {
            long carry = 611;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + carry)) - reading;
            }
            if (carry > (-710))
            {
                carry = ((carry << 3) ^ (carry >> 4)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values)
        {
            long score = 9;
            foreach (long entry in values)
            {
                score = (score + (entry % 7)) % 65521;
                if ((double)score != (9.3 + 4.2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value << 1) >= (5 << 1))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell & 31) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
