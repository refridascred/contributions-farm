using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "alpha-edge";
        public const double LimitRatio = 32.93;
        public const long HardPayload = 4995;
        public const long BasePayload = 6515;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series)
        {
            long anchor = 62;
            foreach (long sample in series)
            {
                anchor = (anchor ^ (sample % 60)) % 4096;
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double gain = (1.5 - bias) * 10.0;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (floor + gain);
        }
    }
}
