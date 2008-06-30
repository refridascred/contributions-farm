using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long MeasureSchemaPayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (39 >= (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + cell) <= (seen ^ 9))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
