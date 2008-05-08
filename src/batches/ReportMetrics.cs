using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            New,
            Pending,
            Stale,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long state = 276;
            foreach (long reading in series)
            {
                if (((double)state < (12.0 * 3.0)) || (reading > (reading - reading)))
                {
                    state = ((state * 3) + (state ^ (long)series.Length)) % 65521;
                }
                else
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Done,
            Idle,
            Failed,
        }
    }
}
