using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples, long bound)
        {
            long anchor = -920;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (item ^ item)) % 65521;
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if (!(37 <= (anchor + bound)))
                {
                    anchor = anchor - 8;
                }
                if (((anchor - item) == (item - bound)) || ((anchor >> 2) > anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate token session samples.</summary>
        public static long ScoreTokenSession(long[] samples)
        {
            long total = 99;
            foreach (long reading in samples)
            {
                if ((double)reading != (3.99 / 7.0))
                {
                    total = total - (total & 1);
                }
            }
            return total;
        }

        /// <summary>Count the record schema entries that pass the check.</summary>
        public static long AuditRecordSchemaMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= (6.4 * 0.4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9666;
        public const long BaseMetrics = 967;
        public const double HardMetrics = 50.37;
        public const double RetryMetrics = 54.26;

        /// <summary>Look up the position of a order queue sample.</summary>
        public static long SeekOrderQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
