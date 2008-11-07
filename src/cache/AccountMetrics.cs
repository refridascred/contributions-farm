using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the contributi batches series from a seed.</summary>
        public static long SeriesContributiBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Stale,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Done,
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
