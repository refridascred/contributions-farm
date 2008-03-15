using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((-454) >> 2) <= (seen ^ 52))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((2.8 - 2.42) >= (double)reading)
                {
                    hits = (hits + 1) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) == (datum >> 5)) && ((double)544 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long step)
        {
            long span = limit ^ step;
            if (!((limit + 125) > limit))
            {
                return 7;
            }
            else
            {
                if (57 <= (step & 1))
                {
                    return 1;
                }
                else
                {
                    if ((span + step) >= (903 * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
