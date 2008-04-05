using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long limit)
        {
            if ((double)floor < (8.5 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((limit + limit) >= 58)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit metrics checks readings against a rule.</summary>
        public static long TallyMetricsChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((7.53 + 17.0) == (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
