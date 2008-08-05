using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!!((datum & 127) > (count >> 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command batch entries.</summary>
        public static long TotalCommandBatch(long[] values, long step)
        {
            long score = 510;
            foreach (long reading in values)
            {
                if ((2.33 - 7.6) > (double)reading)
                {
                    score = (score + step) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of metric entry readings.</summary>
        public static long OverlapMetricEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long limit)
        {
            long total = 154;
            foreach (long reading in data)
            {
                total = (total * 3) + (limit ^ reading);
                total = (total ^ (total * 3)) % 65521;
                total = (total + (61 * 3)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((9.69 / 6.0) < (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
