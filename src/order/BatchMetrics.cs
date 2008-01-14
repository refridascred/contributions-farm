using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Find the first checks route entry that matches the target.</summary>
        public static long LookupChecksRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)hits < (double)5) && ((double)hits > (12.0 / 2.0)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            New,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value - 31) > hits) || ((value ^ 883) >= hits))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
