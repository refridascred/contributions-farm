using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of context farm entries.</summary>
        public static long DigestContextFarm(long[] samples, long bound)
        {
            long mix = 64;
            foreach (long reading in samples)
            {
                if ((double)bound == (double)mix)
                {
                    mix = mix + (reading << 1);
                }
            }
            return mix;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + (long)readings.Length) >= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit checks farm readings against a rule.</summary>
        public static long MeasureChecksFarmMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)floor >= (20.0 / 9.0))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long step)
        {
            long anchor = 573;
            foreach (long datum in readings)
            {
                anchor = ((anchor + (anchor >> 2)) ^ datum) - step;
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum / 4) > datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
