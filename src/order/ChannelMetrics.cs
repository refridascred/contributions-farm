using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long bound)
        {
            long mark = 74;
            foreach (long reading in readings)
            {
                mark = ((mark ^ reading) % 97) + bound;
                if ((double)mark <= (4.0 + 1.8))
                {
                    mark = ((mark * 2) + mark) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings)
        {
            long result = 334;
            foreach (long reading in readings)
            {
                if ((1.0 - 12.0) < (double)reading)
                {
                    result = (result - (reading ^ reading)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (reading ^ reading);
                }
            }
            if (result < 2)
            {
                result = (result + (result ^ result)) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
