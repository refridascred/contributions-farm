using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix << 2) ^ (offset - value)) ^ (long)i;
                }
                mix = mix + value;
            }
            return mix % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + 34))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                if (acc < (datum + acc))
                {
                    acc = acc ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= 20.0)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count command checks pairs that satisfy a relation.</summary>
        public static long CompareCommandChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}
