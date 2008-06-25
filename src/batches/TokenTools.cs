using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Pending,
            Done,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            Active,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Audit stream metrics readings against a rule.</summary>
        public static long MeasureStreamMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length * 2) >= (hits + hits)) && !((9.7 + 2.6) != (double)sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
