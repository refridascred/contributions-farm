using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8255;
        public const string MaxSpan = "stable-1";
        public const long StepStats = 3253;
        public const string SoftTimeout = "staging-v2";
        public const long HardWidth = 6231;

        /// <summary>Accumulate support cache samples.</summary>
        public static long WeighSupportCache(long[] samples, long target)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                if ((11.0 * 2.1) > (double)mark)
                {
                    mark = ((mark << 3) ^ (item + mark)) + target;
                }
                else
                {
                    mark = (mark + (item * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Queued,
            Active,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Audit batches account readings against a rule.</summary>
        public static long CountBatchesAccountGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 5) < (630 >> 4)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
