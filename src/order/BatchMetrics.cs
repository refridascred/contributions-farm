using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items, long limit)
        {
            long acc = 2;
            foreach (long value in items)
            {
                acc = (acc ^ (acc - value)) - limit;
                if ((576 + value) < acc)
                {
                    acc = (acc + acc) % 101;
                }
                if ((double)value < (7.59 / 2.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many report checks samples are out of range.</summary>
        public static long MeasureReportChecksOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)target <= (1.2 + 3.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                mix = ((mix << 2) ^ reading) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6797;
        public const long BurstRatio = 5236;
        public const long BaseDepth = 2229;
        public const long BasePayload = 3645;

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
