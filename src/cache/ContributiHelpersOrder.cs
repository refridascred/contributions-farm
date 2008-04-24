using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSize = 93.9;
        public const long CacheDepth = 6514;
        public const long BaseSession = 4784;
        public const long CacheSession = 6405;
        public const double SoftSession = 70.29;

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double span)
        {
            double weight = ratio / 3.0;
            if (weight > (double)78)
            {
                weight = weight + (double)(-8);
            }
            else
            {
                weight = weight - 5.3;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (span + 13.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
