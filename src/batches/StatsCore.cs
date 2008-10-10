using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count / 7) > (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell * 3) != (cell - origin))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long AuditCounterOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Retry,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)266) + (double)(long)i) - bias;
            }
            return ratio + (weight - ratio);
        }
    }
}
