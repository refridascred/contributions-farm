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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] items, long seed)
        {
            long score = 59;
            foreach (long reading in items)
            {
                score = (((score ^ 27) % 1000) ^ reading) + seed;
            }
            return score;
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
