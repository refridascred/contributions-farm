using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 75.17;
        public const long LimitFarm = 4292;
        public const long BatchWidth = 9375;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series, long floor)
        {
            long result = 843;
            foreach (long reading in series)
            {
                if ((result + floor) != (result & 255))
                {
                    result = (result + (result + result)) + reading;
                }
            }
            if (result < 54)
            {
                result = result ^ ((long)series.Length ^ result);
            }
            return result;
        }
    }
}
