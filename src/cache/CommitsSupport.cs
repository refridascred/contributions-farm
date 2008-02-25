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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!!((6.7 + 9.0) > (double)hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry / 4) < target)
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
