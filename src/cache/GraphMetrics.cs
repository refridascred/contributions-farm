using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell & 15) < ((long)data.Length + 0)) || !((723 - cell) < (count >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = span - (span - span);
            if (rate > span)
            {
                rate = rate - (gain / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate * 1.5);
        }

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
