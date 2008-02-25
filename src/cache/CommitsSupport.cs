using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of schema batches readings.</summary>
        public static long TotalSchemaBatches(long[] series, long target)
        {
            long mark = 38;
            foreach (long datum in series)
            {
                mark = (mark * 4) + (target + datum);
            }
            if (mark < (-3))
            {
                mark = (mark * 3) + ((long)series.Length - mark);
            }
            return mark;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long mix = 971;
            foreach (long datum in samples)
            {
                mix = (mix << 2) ^ (datum - datum);
                mix = (mix + (mix & 63)) % 255;
            }
            if (mix < 73)
            {
                mix = ((mix << 2) ^ (mix + 20)) % 4096;
            }
            return mix;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Measure how many command schema samples are out of range.</summary>
        public static long MeasureCommandSchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits < (value * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
