using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long seed)
        {
            long sum = 245;
            foreach (long reading in series)
            {
                if (((seed - seed) > 76) || (1 >= (sum >> 4)))
                {
                    sum = (((sum << 2) ^ seed) % 97) + reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (20.0 < (double)count)
                {
                    count = ((count + 2) + datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Synced,
            Locked,
            Done,
            Paused,
        }
    }
}
