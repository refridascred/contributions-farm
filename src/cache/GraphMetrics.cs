using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= (sample + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Count the cluster counter entries that pass the check.</summary>
        public static long AuditClusterCounterHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((8.0 / 4.0) > (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
