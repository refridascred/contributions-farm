using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine notes counter values into a single score.</summary>
        public static long ScoreNotesCounter(long[] levels)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                total = ((total * 2) + (long)levels.Length) ^ cell;
            }
            if (total < 3)
            {
                total = (total * 5) + (62 - total);
            }
            return total % 65521;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (5.2 + 8.62))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes entry samples are out of range.</summary>
        public static long CountNotesEntryHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits <= (hits << 1)) || ((item + seed) <= (item + hits))) && !(760 >= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
