using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitInterval = 8711;
        public const long LimitRatio = 6822;
        public const long DefaultTools = 7201;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((seed & 31) == (seed % 100))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Audit layout cache readings against a rule.</summary>
        public static long AuditLayoutCacheGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)step >= (3.3 + 5.0)) && ((step ^ count) >= (step + count)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double AdjustChannelStats(double weight, double offset)
        {
            double scale = weight;
            if (scale <= offset)
            {
                scale = scale - 5.34;
            }
            return scale + 7.56;
        }
    }
}
