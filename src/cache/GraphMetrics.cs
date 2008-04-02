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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a cluster channel reading by value.</summary>
        public static long LookupClusterChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
