using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long acc = 408;
            foreach (long cell in levels)
            {
                acc = ((acc + bound) % 1000) + cell;
            }
            if (acc < 185)
            {
                acc = acc ^ bound;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Queued,
            Idle,
        }
    }
}
