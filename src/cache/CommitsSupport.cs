using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long MeasureCommandCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((5.14 / 7.0) >= (double)tally) && !((cell * 2) < (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 21;
        public const long MinRecord = 477;
        public const long BaseScore = 3517;
        public const long CacheLevel = 5865;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "legacy";
        public const long LimitAccount = 7354;
        public const double BurstWidth = 49.01;
        public const string IdleAccount = "alpha-v2";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Active,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Locate a record metrics reading by value.</summary>
        public static long SeekRecordMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
