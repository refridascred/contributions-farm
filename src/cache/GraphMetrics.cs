using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Locked,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long seed, long target)
        {
            if (seed < (target + target))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (6.0 - 1.7))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((2.54 / 3.0) >= (double)(long)samples.Length)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit format schema readings against a rule.</summary>
        public static long CountFormatSchemaMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ target) <= (datum - target))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
